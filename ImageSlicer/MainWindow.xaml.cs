using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageSlicer
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrLines = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            InitControl();
        }

        private void InitControl()
        {
            this.btnSelectImage.Click += BtnSelectImage_Click;
            this.btnAddLine.Click += BtnAddLine_Click;
            this.btnsplit.Click += Btnsplit_Click;
        }

        private void BtnSelectImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();

                if(ofd.ShowDialog() == true)
                {
                    this.tbImageName.Text = ofd.FileName;

                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(tbImageName.Text);
                    bitmap.EndInit();

                    imgMain.Source = bitmap;

                    imgMain.Width = bitmap.Width;
                }
            }
            catch(Exception ex)
            {
                LOG.ex(ex);
            }
        }

        private void BtnAddLine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UCLine newLine = new UCLine();

                canvasImage.Children.Add(newLine);

                newLine.Width = imgMain.Width;
                newLine.Height = 30;

                Canvas.SetTop(newLine, scrImage.VerticalOffset + scrImage.ActualHeight / 2);

                arrLines.Add(newLine);

            }
            catch (Exception ex)
            {
                LOG.ex(ex);
            }
        }

        private void Btnsplit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                LOG.ex(ex);
            }
        }
    }
}
