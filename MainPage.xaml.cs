namespace kruh_vypocet
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

        }

        private void VypocitejBtnClicked(object sender, EventArgs e)
        {
            string polomerVstup = PolomerEntry.Text;
            double obvod = Vypocty.VypisObvod(polomerVstup);
            VysledekObvodLabel.Text = $"Obvod: {obvod}";
        }
    }
    internal static class Vypocty
    {
        public static double VypisObvod(string polomerText)
        {
            if (double.TryParse(polomerText, out double polomer))
            {
                return VypocitejObvod(polomer);


            }
            else
            {
                return 0; 
            }
        }
        private static double VypocitejObvod(double polomer)
        {
            return 2 * Math.PI * polomer;
        }
    }
}
