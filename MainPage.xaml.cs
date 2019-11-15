using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace TestNhanVien
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetNhanViens();
        }
        public async void GetNhanViens()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://192.168.1.87/vietgapservice/api/nhanviens");
            var nhanvien = JsonConvert.DeserializeObject<List<GetNhanViens>>(response);
           List nhanvien
            ListNhanvien.ItemsSource = nhanvien;
            
        }

        

        private void btnLayDanhSach_Clicked(object sender, EventArgs e)
        {
            GetNhanViens();
        }
    }
}
