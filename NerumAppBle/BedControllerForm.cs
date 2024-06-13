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
                        DateTimePickerAlarmTime.Value = new DateTime(2000, 1, 1, e.Time1.Hour, e.Time1.Minute, 0);
                        DateTimePickerAlarmTime2.Value = new DateTime(2000, 1, 1, e.Time2.Hour, e.Time2.Minute, 0);
                        DateTimePickerAlarmTime3.Value = new DateTime(2000, 1, 1, e.Time3.Hour, e.Time3.Minute, 0);
                        RadioButtonAlarmOn.Checked = e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.あり);
                        RadioButtonAlarmOff.Checked = !e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.あり);
                        RadioButtonAlarmOn2.Checked = e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.あり);
                        RadioButtonAlarmOff2.Checked = !e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.あり);
                        RadioButtonAlarmOn3.Checked = e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.あり);
                        RadioButtonAlarmOff3.Checked = !e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.あり);
                        ListBoxAlarmMode.SelectedItem = e.Type1 switch
                        {
                            NerumAppDevice.AlarmType.なし => "なし",
                            NerumAppDevice.AlarmType.M1 => "M1",
                            NerumAppDevice.AlarmType.M2 => "M2",
                            NerumAppDevice.AlarmType.灯り => "灯り",
                            _ => "なし"
                        };
                        ListBoxAlarmMode2.SelectedItem = e.Type2 switch
                        {
                            NerumAppDevice.AlarmType.なし => "なし",
                            NerumAppDevice.AlarmType.M1 => "M1",
                            NerumAppDevice.AlarmType.M2 => "M2",
                            NerumAppDevice.AlarmType.灯り => "灯り",
                            _ => "なし"
                        };
                        ListBoxAlarmMode3.SelectedItem = e.Type3 switch
                        {
                            NerumAppDevice.AlarmType.なし => "なし",
                            NerumAppDevice.AlarmType.M1 => "M1",
                            NerumAppDevice.AlarmType.M2 => "M2",
                            NerumAppDevice.AlarmType.灯り => "灯り",
                            _ => "なし"
                        };
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(0, e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.日曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(1, e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.月曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(2, e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.火曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(3, e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.水曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(4, e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.木曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(5, e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.金曜日));
                        CheckedListBoxAlarmDayOfWeek.SetItemChecked(6, e.Repeat1.HasFlag(NerumAppDevice.AlarmRepeat.土曜日));
                        CheckedListBoxAlarmDayOfWeek2.SetItemChecked(0, e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.日曜日));
                        CheckedListBoxAlarmDayOfWeek2.SetItemChecked(1, e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.月曜日));
                        CheckedListBoxAlarmDayOfWeek2.SetItemChecked(2, e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.火曜日));
                        CheckedListBoxAlarmDayOfWeek2.SetItemChecked(3, e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.水曜日));
                        CheckedListBoxAlarmDayOfWeek2.SetItemChecked(4, e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.木曜日));
                        CheckedListBoxAlarmDayOfWeek2.SetItemChecked(5, e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.金曜日));
                        CheckedListBoxAlarmDayOfWeek2.SetItemChecked(6, e.Repeat2.HasFlag(NerumAppDevice.AlarmRepeat.土曜日));
                        CheckedListBoxAlarmDayOfWeek3.SetItemChecked(0, e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.日曜日));
                        CheckedListBoxAlarmDayOfWeek3.SetItemChecked(1, e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.月曜日));
                        CheckedListBoxAlarmDayOfWeek3.SetItemChecked(2, e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.火曜日));
                        CheckedListBoxAlarmDayOfWeek3.SetItemChecked(3, e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.水曜日));
                        CheckedListBoxAlarmDayOfWeek3.SetItemChecked(4, e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.木曜日));
                        CheckedListBoxAlarmDayOfWeek3.SetItemChecked(5, e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.金曜日));
                        CheckedListBoxAlarmDayOfWeek3.SetItemChecked(6, e.Repeat3.HasFlag(NerumAppDevice.AlarmRepeat.土曜日));
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
            var alerm1 = GetAlermType(RadioButtonAlarmOff, ListBoxAlarmMode, CheckedListBoxAlarmDayOfWeek, DateTimePickerAlarmTime);
            var alerm2 = GetAlermType(RadioButtonAlarmOff2, ListBoxAlarmMode2, CheckedListBoxAlarmDayOfWeek2, DateTimePickerAlarmTime2);
            var alerm3 = GetAlermType(RadioButtonAlarmOff3, ListBoxAlarmMode3, CheckedListBoxAlarmDayOfWeek3, DateTimePickerAlarmTime3);
            await device.SetAlarmAsync(
                alerm1.time, alerm1.alarmRepeat, alerm1.alarmType,
                alerm2.time, alerm2.alarmRepeat, alerm2.alarmType,
                alerm3.time, alerm3.alarmRepeat, alerm3.alarmType
                );
            //編集を終了して表示中にする

            ButtonToggleEditMode_Click(sender, e);
        }

        private static (TimeOnly time,NerumAppDevice.AlarmRepeat alarmRepeat,  NerumAppDevice.AlarmType alarmType) GetAlermType(RadioButton radioButtonAlarmOff, ListBox listBoxAlarmMode, CheckedListBox checkedListBoxAlarmDayOfWeek, DateTimePicker dateTimePickerAlarmTime)
        {
            NerumAppDevice.AlarmRepeat alarmRepeat;
            NerumAppDevice.AlarmType alarmType;
            TimeOnly time = TimeOnly.FromDateTime(dateTimePickerAlarmTime.Value);
            if (radioButtonAlarmOff.Checked)
            {
                alarmRepeat = NerumAppDevice.AlarmRepeat.なし;
            }
            else
            {
                alarmRepeat = NerumAppDevice.AlarmRepeat.あり;
                if (checkedListBoxAlarmDayOfWeek.CheckedItems.Contains("日曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.日曜日;
                }
                if (checkedListBoxAlarmDayOfWeek.CheckedItems.Contains("月曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.月曜日;
                }
                if (checkedListBoxAlarmDayOfWeek.CheckedItems.Contains("火曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.火曜日;
                }
                if (checkedListBoxAlarmDayOfWeek.CheckedItems.Contains("水曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.水曜日;
                }
                if (checkedListBoxAlarmDayOfWeek.CheckedItems.Contains("木曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.木曜日;
                }
                if (checkedListBoxAlarmDayOfWeek.CheckedItems.Contains("金曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.金曜日;
                }
                if (checkedListBoxAlarmDayOfWeek.CheckedItems.Contains("土曜日"))
                {
                    alarmRepeat |= NerumAppDevice.AlarmRepeat.土曜日;
                }
            }
            alarmType = listBoxAlarmMode.SelectedItem switch
            {
                "M1" => NerumAppDevice.AlarmType.M1,
                "M2" => NerumAppDevice.AlarmType.M2,
                "灯り" => NerumAppDevice.AlarmType.灯り,
                _ => NerumAppDevice.AlarmType.なし,
            };
            return (time, alarmRepeat, alarmType);
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
            ButtonSaveAlarm.Enabled = IsAlarmEditable;

            ListBoxAlarmMode.Enabled = IsAlarmEditable;
            CheckedListBoxAlarmDayOfWeek.Enabled = IsAlarmEditable;
            DateTimePickerAlarmTime.Enabled = IsAlarmEditable;
            RadioButtonAlarmOn.Enabled = IsAlarmEditable;
            RadioButtonAlarmOff.Enabled = IsAlarmEditable;

            ListBoxAlarmMode2.Enabled = IsAlarmEditable;
            CheckedListBoxAlarmDayOfWeek2.Enabled = IsAlarmEditable;
            DateTimePickerAlarmTime2.Enabled = IsAlarmEditable;
            RadioButtonAlarmOn2.Enabled = IsAlarmEditable;
            RadioButtonAlarmOff2.Enabled = IsAlarmEditable;

            ListBoxAlarmMode3.Enabled = IsAlarmEditable;
            CheckedListBoxAlarmDayOfWeek3.Enabled = IsAlarmEditable;
            DateTimePickerAlarmTime3.Enabled = IsAlarmEditable;
            RadioButtonAlarmOn3.Enabled = IsAlarmEditable;
            RadioButtonAlarmOff3.Enabled = IsAlarmEditable;
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
