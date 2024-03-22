using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RTSDecoder
{
    public partial class DecoderForm : Form
    {
        DecoderResultForm _decoderResultForm;
        private int _movingTypeIndex;
        
        List<MovementData> _parameters = TrainData.Main;
        
        int _countSpeedA;
        private static int _countBrakeA;
        private static int _countOtherA;
        
        public DecoderForm()
        {
            InitializeComponent();

            double averageSpeed = Math.Round(CalculateAverageSpeed(), 2);
            double maxUr = Math.Round(FindMaxUr(), 2);
            
            FindSpeedA();
            FindBrakesA();
            FindOtherA();

            statSpeed.Text = "Средняя скорость: " + averageSpeed + " км/ч";
            statUR.Text = "Максимальное давление УР: " + maxUr + " кгс/см2";
            statBrakeA.Text = "Нарушения по тормозам: " + _countBrakeA;
            statSpeedA.Text = "Нарушения по скоростям: " + _countSpeedA;
            statOtherA.Text = "Прочие нарушения: " + _countOtherA;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            _decoderResultForm = new DecoderResultForm();
            _decoderResultForm.Show();
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Текущие нарушения будут удалены", "Вы уверены?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                WizardData.Main.Clear();
                AutoDecoder decoder = new AutoDecoder();

                _movingTypeIndex = 1;
                
                for (var i = 0; i < _parameters.Count; i++)
                {
                    decoder.CheckSpeed(_movingTypeIndex,_parameters[i].Time, _parameters[i].RealTime, _parameters[i].Speed,
                        _parameters[i].SpeedLimit);
                    decoder.CheckSpeedToSignal(_movingTypeIndex,_parameters[i].Time, _parameters[i].RealTime, _parameters[i].Signal,
                        _parameters[i].SSignal, _parameters[i].Speed);
                    decoder.CheckSignalEblan(_movingTypeIndex, _parameters[i].Time, _parameters[i].RealTime,
                        _parameters[i].Signal, _parameters[i].Speed, _parameters[i].SpeedLimit);
                }

                FindSpeedA();
                FindBrakesA();
                FindOtherA();
                
                statBrakeA.Text = "Нарушения по тормозам: " + _countBrakeA;
                statSpeedA.Text = "Нарушения по скоростям: " + _countSpeedA;
                statOtherA.Text = "Прочие нарушения: " + _countOtherA;
            }
        }

        private double CalculateAverageSpeed()
        {
            double totalSpeed = 0;
            
            foreach (MovementData obj in _parameters)
            {
                totalSpeed += obj.Speed;
            }

            return totalSpeed / _parameters.Count;
        }

        private double FindMaxUr()
        {
            double maxUr = double.MinValue;

            foreach (MovementData obj in _parameters)
            {
                if (obj.Ur > maxUr)
                    maxUr = obj.Ur;
            }

            return maxUr;
        }

        private void FindSpeedA()
        {
            _countSpeedA = 0;
            
            foreach (CheckData obj in WizardData.Main)
            {
                if (obj.Type.Equals("Exceeding") | obj.Type.Equals("ExceedingToSignal") | obj.Type.Equals("ManualSpeed"))
                    _countSpeedA++;
            }
        }
        
        private void FindBrakesA()
        {
            _countBrakeA = 0;
            
            foreach (CheckData obj in WizardData.Main)
            {
                if (obj.Type.Equals("ManualBrakes"))
                    _countBrakeA++;
            }
        }
        
        private void FindOtherA()
        {
            _countOtherA = 0;
            
            foreach (CheckData obj in WizardData.Main)
            {
                if (obj.Type.Equals("ManualOther"))
                    _countOtherA++;
            }
        }
    }
}
