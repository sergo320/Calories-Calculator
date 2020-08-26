using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CaloriesCalculator
{
    public partial class MainPage : ContentPage
    {
        private int coff_floor = 5;
        float coff_activity = 1.2f;
        public MainPage()
        {
            InitializeComponent();
        }
        private void activity_coefficient(object sender, EventArgs e)
        {
            var selectActivity = activity.Items[activity.SelectedIndex];
            switch (selectActivity)
            {
                case "Физическая нагрузка минимальная или отсутствует":
                    coff_activity = 1.2f;
                    break;
                case "Тренировки средней тяжести 3 раза в неделю":
                    coff_activity = 1.38f;
                    break;
                case "Тренировки средней тяжести 5 раза в неделю":
                    coff_activity = 1.46f;
                    break;
                case "Интенсивные тренировки 5 раз в неделю":
                    coff_activity = 1.55f;
                    break;
                case "Тренировки каждый день":
                    coff_activity = 1.64f;
                    break;
                case "Интенсивные тренировки каждый день или по 2 раза в день":
                    coff_activity = 1.73f;
                    break;
                case "ежедневная работа + физическая работа":
                    coff_activity = 1.9f;
                    break;

            }
        }
        private void floor(object sender, EventArgs e)
        {
            var floor = floorPicker.Items[floorPicker.SelectedIndex];
            switch (floor)
            {
                case "man":
                    coff_floor = 5;
                    break;
                case "women":
                    coff_floor = -161;
                    break;
            }
        }
        private void count(object sender, EventArgs e)
        {
            float weight = Convert.ToSingle(this.weight.Text);
            float height = Convert.ToSingle(this.height.Text);
            float age = Convert.ToSingle(this.age.Text);
            float coffFloar = coff_floor;
            float coffActivity = coff_activity;

            double dci;
            dci = ((weight*10)+(height*6.25)-(age*5)+coff_activity)*coff_activity;
            dci = Math.Round(dci, MidpointRounding.ToEven);
            result.Text = dci.ToString() + " калорий";
        }

    }
}
