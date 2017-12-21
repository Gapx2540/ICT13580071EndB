using ICT13580071EndB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ICT13580071EndB
  {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductNewPage : ContentPage
    {
        Product product;
        public ProductNewPage()
        {
            InitializeComponent();

            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;

            TypecarPicker.Items.Add("กระบะ");
            TypecarPicker.Items.Add("เก๋ง");
            TypecarPicker.Items.Add("รถบ้าน");
            TypecarPicker.Items.Add("4X4");


            BrandPicker.Items.Add("honda");
            BrandPicker.Items.Add("toyota");
            BrandPicker.Items.Add("mazda");
            BrandPicker.Items.Add("Lambogini");
            BrandPicker.Items.Add("Ferrari");

            ProvicePicker.Items.Add("Bangkok");
            ProvicePicker.Items.Add("Saraburi");
            ProvicePicker.Items.Add("Surattani");
            ProvicePicker.Items.Add("Kanjanaburi");
            if (product != null)
            {
                TypeEntry.Text = product.Type;
                

            }

        }
        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการค้นหาใช่หรือไม่", "ใช่", "ไม่ใช่");

            if (isOk)
            {
                if (product == null)
                {
                    var product = new Product();
                    product.Type = TypeEntry.Text;
                    product.Price = int.Parse(PriceEntry.Text);
                    TypecarPicker.SelectedItem = product.Typecar;
                    BrandPicker.SelectedItem = product.Brand;
                    product.Phone = int.Parse(PhoneEntry.Text);
                    ProvicePicker.SelectedItem = product.Provice;
                    product.description = descriptionEditor.Text;


                    var id = App.DbHelper.AddProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "สินค้าของท่านคือ" + id, "ตกลง");

                }
                else
                {
                    product.Type = TypeEntry.Text;
                    product.Price = int.Parse(PriceEntry.Text);
                    TypecarPicker.SelectedItem = product.Typecar;
                    BrandPicker.SelectedItem = product.Brand;
                    product.Phone = int.Parse(PhoneEntry.Text);
                    ProvicePicker.SelectedItem = product.Provice; ;
                    product.description = descriptionEditor.Text;


                    var id = App.DbHelper.UpdateProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "แก้ไขข้อมูลสินค้า" + id, "ตกลง");
                }
                await Navigation.PopModalAsync();
            }
        }



        private void CancelButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}


