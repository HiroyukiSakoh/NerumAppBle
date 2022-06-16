using Windows.Devices.Bluetooth;

namespace NerumAppBle
{
    public partial class BedControllerForm : Form
    {
        private readonly NerumAppDevice device = null!;
        private MainForm mainForm = null!;

        public BedControllerForm()
        {
            InitializeComponent();
        }

        public BedControllerForm(BluetoothLEDevice bleDevice)
        {
            device = new NerumAppDevice(bleDevice);
            device.DebugLog += (s, e) =>
            {
                mainForm?.DebugForm?.DebugAppend(e.Value);
            };
            device.OnNotifyBedStatus += (s, e) =>
            {
                Invoke(() =>
                {
                    LabelHeadValue.Text = $"{e.HeadDegree / (float)HeadDegreeMax:P}";
                    LabelFootValue.Text = $"{e.FootDegree / (float)FootDegreeMax:P}";
                    LabelLightValue.Text = e.IsLightOn ? "ON" : "OFF";
                });
            };
            device.OnNotifyAlarmStatus += (s, e) =>
            {
                if (!IsAlarmEditable)
                {
                    Invoke(() =>
                    {
                        DateTimePickerAlarmTime.Value = new DateTime(2000, 1, 1, e.Time.Hour, e.Time.Minute, 0);
                        RadioButtonAlarmOn.Checked = e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.あり);
                        RadioButtonAlarmOff.Checked = !e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.あり);
                        ListBoxAlarmMode.SelectedItem = e.Type switch
                        {
                            NerumAppDevice.AlarmType.なし => "なし",
                            NerumAppDevice.AlarmType.M1 => "M1",
                            NerumAppDevice.AlarmType.M2 => "M2",
                            NerumAppDevice.AlarmType.灯り => "灯り",
                            _ => "なし"
                        };
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(0, e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.日曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(1, e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.月曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(2, e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.火曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(3, e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.水曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(4, e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.木曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(5, e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.金曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(6, e.Repeat.HasFlag(NerumAppDevice.AlarmRepeat.土曜日));
                    });
                }
            };
            device.OnNotifyDateTime += (s, e) =>
            {
                Invoke(() =>
                {
                    LabelDateTimeValue.Text = e.DateTime.ToString("yyyy/MM/dd HH:mm:ss");
                });
            };
            InitializeComponent();
        }

        private const ushort HeadDegreeMax = 0x3338;//33D3,336D
        private const ushort FootDegreeMax = 0x242E;//2490,245E

        private async void BedControllerForm_Load(object sender, EventArgs e)
        {
            mainForm = (MainForm)Owner;
            await device.InitializeAsync();
            Text = device.DeviceName;

            TabControlMain.Enabled = true;
        }

        private async void BedControllerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device != null)
            {
                await device.DisposeAsync();
            }
        }

        private async void ButtonLight_Click(object sender, EventArgs e)
        {
            await device.ToggleLightAsync();
        }

        private async void ButtonMemory1_Click(object sender, EventArgs e)
        {
            await device.ToMemory1Async();
        }

        private async void ButtonMemory2_Click(object sender, EventArgs e)
        {

            await device.ToMemory1Async();
        }

        private async void ButtonHeadUp_Click(object sender, EventArgs e)
        {
            await device.HeadUpAsync();
        }

        private async void ButtonHeadDown_Click(object sender, EventArgs e)
        {
            await device.HeadDownAsync();
        }

        private async void ButtonFootUp_Click(object sender, EventArgs e)
        {
            await device.FootUpAsync();
        }

        private async void ButtonFootDown_Click(object sender, EventArgs e)
        {
            await device.FootDownAsync();
        }

        private async void ButtonFlat_Click(object sender, EventArgs e)
        {
            await device.ToFlatAsync();
        }

        private async void ButtonAntiSnore_Click(object sender, EventArgs e)
        {
            await device.ToAntiSnoreAsync();
        }

        private async void ButtonZeroG_Click(object sender, EventArgs e)
        {
            await device.ToZeroGAsync();
        }

        private async void ButtonReading_Click(object sender, EventArgs e)
        {
            await device.ToLoungeAsync();
        }

        private async void ButtonStop_Click(object sender, EventArgs e)
        {
            await device.StopAsync();
        }

        private async void ButtonQuery_Click(object sender, EventArgs e)
        {
            await device.QueryAsync();
        }

        private async void ButtonUnionUp_Click(object sender, EventArgs e)
        {
            await device.UnionUpAsync();
        }

        private async void ButtonUnionDown_Click(object sender, EventArgs e)
        {
            await device.UnionDownAsync();
        }

        private async void ButtonSaveAlarm_Click(object sender, EventArgs e)
        {
            NerumAppDevice.AlarmRepeat alarmRepeat;
            if (RadioButtonAlarmOff.Checked)
            {
                alarmRepeat = NerumAppDevice.AlarmRepeat.なし;
            }
            else
            {
                alarmRepeat = NerumAppDevice.AlarmRepeat.あり;
                if (CheckedListBoxAlarmDayOfWeek.CheckedItems.Contains("日曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.日曜日;
                }
                if (CheckedListBoxAlarmDayOfWeek.CheckedItems.Contains("月曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.月曜日;
                }
                if (CheckedListBoxAlarmDayOfWeek.CheckedItems.Contains("火曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.火曜日;
                }
                if (CheckedListBoxAlarmDayOfWeek.CheckedItems.Contains("水曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.水曜日;
                }
                if (CheckedListBoxAlarmDayOfWeek.CheckedItems.Contains("木曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.木曜日;
                }
                if (CheckedListBoxAlarmDayOfWeek.CheckedItems.Contains("金曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.金曜日;
                }
                if (CheckedListBoxAlarmDayOfWeek.CheckedItems.Contains("土曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.土曜日;
                }
            }
            NerumAppDevice.AlarmType alarmType = ListBoxAlarmMode.SelectedItem switch
            {
                "M1" => NerumAppDevice.AlarmType.M1,
                "M2" => NerumAppDevice.AlarmType.M2,
                "灯り" => NerumAppDevice.AlarmType.灯り,
                _ => NerumAppDevice.AlarmType.なし,
            };
            await device.SetAlarmAsync(TimeOnly.FromDateTime(DateTimePickerAlarmTime.Value), alarmRepeat, alarmType);
            //編集を終了して表示中にする

            ButtonToggleEditMode_Click(sender, e);
        }

        private async void ButtonSetDateTime_Click(object sender, EventArgs e)
        {
            await device.SetDateTimeAsync(DateTime.Now);
        }

        private bool IsAlarmEditable = false;

        private void ButtonToggleEditMode_Click(object sender, EventArgs e)
        {
            IsAlarmEditable = !IsAlarmEditable;
            LabelEditMode.Text = IsAlarmEditable ? "編集中" : "表示中";
            ListBoxAlarmMode.Enabled = IsAlarmEditable;
            CheckedListBoxAlarmDayOfWeek.Enabled = IsAlarmEditable;
            DateTimePickerAlarmTime.Enabled = IsAlarmEditable;
            ButtonSaveAlarm.Enabled = IsAlarmEditable;
            RadioButtonAlarmOn.Enabled = IsAlarmEditable;
            RadioButtonAlarmOff.Enabled = IsAlarmEditable;
        }

        private async void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlMain.SelectedTab == TabPageAlarm)
            {
                await device.SetNotifyAlarmStatusAsync();
            }
            if (TabControlMain.SelectedTab == TabPageBed)
            {
                await device.SetNotifyBedStatusAsync();
            }
        }
    }
}
