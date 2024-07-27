using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MicToggler
{
    public partial class MicToggler : Form
    {
        private const int WM_HOTKEY = 0x0312;
        private const int HOTKEY_ID = 1; // Identificador del atajo de teclado
        private CoreAudioController _audioController;
        private CoreAudioDevice _defaultMicDevice;
        private bool _isMicrophoneMuted = false; // Estado del micrófono
        private Icon micEnabledIcon;
        private Icon micDisabledIcon;
        private KeyModifiers currentModifier = KeyModifiers.Alt;
        private Keys currentKey = Keys.M;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        Point lastPoint;

        public MicToggler()
        {
            InitializeComponent();
            _audioController = new CoreAudioController();
            RegisterGlobalHotKey();
            SetDefaultMicrophone();

            // Cargar los íconos
            micEnabledIcon = Properties.Resources.micEnabledIcon;
            micDisabledIcon = Properties.Resources.micDisabledIcon;

            // Preseleccionar (Visiblemente) Atajos
            modifierCombo.SelectedIndex = 1;
            keyCombo.SelectedIndex = 12;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // Restaurar la ventana al hacer doble clic en el ícono
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void SetDefaultMicrophone()
        {
            // Obtener la lista de dispositivos de grabación
            var devices = _audioController.GetDevices(DeviceType.Capture).ToList();

            // Encontrar el micrófono predeterminado
            _defaultMicDevice = devices.FirstOrDefault(d => d.IsDefaultDevice);

            if (_defaultMicDevice == null)
            {
                MessageBox.Show("No se encontró un micrófono predeterminado.", "Error");
            }
        }

        private void top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterGlobalHotKey()
        {
            // Registro del atajo de teclado Alt + M
            RegisterHotKey(this.Handle, HOTKEY_ID, (uint)KeyModifiers.Alt, (uint)Keys.M);
        }

        private void UnregisterGlobalHotKey()
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                // Llama al método ToggleMicrophone cuando se detecta el atajo
                ToggleMicrophone();
            }
            base.WndProc(ref m);
        }

        private void ToggleMicrophone()
        {
            if (_defaultMicDevice != null)
            {
                // Alternar el estado de muteo
                _isMicrophoneMuted = !_isMicrophoneMuted;
                if (_isMicrophoneMuted)
                {
                    _defaultMicDevice.Mute(true);
                    notifyIcon1.Icon = micDisabledIcon;
                }
                else
                {
                    _defaultMicDevice.Mute(false);
                    notifyIcon1.Icon = micEnabledIcon;
                }

                // Mostrar el estado actual del micrófono
                //string status = _isMicrophoneMuted ? "Deshabilitado" : "Habilitado";
                // MessageBox.Show($"Micrófono {status}", "Estado del Micrófono");
            }
            else
            {
                MessageBox.Show("No se encontró un micrófono predeterminado.", "Error");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterGlobalHotKey();
            notifyIcon1.Visible = false;
            base.OnFormClosing(e);
        }

        private void closeApp_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeApp_but_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void applyHotkey_but_Click(object sender, EventArgs e)
        {
            // Guardar la configuración del atajo de teclado
            Enum.TryParse(modifierCombo.SelectedItem.ToString(), out currentModifier);
            Enum.TryParse(keyCombo.SelectedItem.ToString(), out currentKey);

            // Registrar el nuevo atajo de teclado
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            bool isKeyRegistered = RegisterHotKey(this.Handle, HOTKEY_ID, (uint)currentModifier, (uint)currentKey);
            if (!isKeyRegistered)
            {
                MessageBox.Show("No se pudo registrar el atajo de teclado", "Error");
            }
            else
            {
                MessageBox.Show("Atajo de teclado guardado", "Información");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dariohsb");
        }
    }
}
