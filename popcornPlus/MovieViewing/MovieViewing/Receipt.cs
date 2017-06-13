using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace MovieViewing
{
    public partial class Receipt : MetroFramework.Forms.MetroForm
    {
        private PrintDocument doc = new PrintDocument();
        private Font printFont;
        private StreamReader streamToPrint;
        string dir = @"C:\Users\cob11.LYTC\Desktop\GitHub\Popcorn\popcornPlus\Receipt.txt";
        private string[] lines = { "Title\n", "Screen\n", "RunTime", "Seat", "Date", "Ticket Price", "Total" };
        DateTime today = DateTime.Today;
        public Receipt()
        {
            InitializeComponent();
            createReceipt();
            create_Report();
        }

        public void createReceipt()
        {
            lblTitle.Text = SeatBooking.Title;
            lblSeat.Text = SeatBooking.Seats;
            lblPrice.Text = SeatBooking.Price;
            lblDate.Text = today.ToShortDateString()+"  "+SeatBooking.Date;
            lblRunTime.Text = SeatBooking.Runtime;
            lblTotal.Text = SeatBooking.Totalprice;
            lblScreen.Text = SeatBooking.Auditorium;
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void doc_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
       

        private void create_Report()
        {
            
            using (System.IO.StreamWriter file =new System.IO.StreamWriter(dir))
            {
                file.WriteLine("                Porpcorn Receipt");
                file.WriteLine("");
                file.WriteLine("Title" +"               "+ lblTitle.Text);
                file.WriteLine("");
                file.WriteLine("Screen" +"              " + lblScreen.Text);
                file.WriteLine("");
                file.WriteLine("\nRunTime" + "             " + lblRunTime.Text);
                file.WriteLine("");
                file.WriteLine("\nSeat" + "               " + lblSeat.Text);
                file.WriteLine("");
                file.WriteLine("\nDate" + "                " + lblDate.Text);
                file.WriteLine("");
                file.WriteLine("\nTicket Price" + "        " + lblPrice.Text);
                file.WriteLine("");
                file.WriteLine("\nTotal" + "               " + lblTotal.Text);              
            }

        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.txtTicket.Text, this.txtTicket.Font, Brushes.Black, 10, 25);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            try
            {
                streamToPrint = new StreamReader
                   (dir);
                try
                {
                    printFont = new Font("Berlin Sans FB", 12);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();   
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
