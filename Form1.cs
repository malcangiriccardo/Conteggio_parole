namespace Conteggio_parole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcola_Click(object sender, EventArgs e)
        {

            int contaparole = 1, i;

            if (string.IsNullOrWhiteSpace(txt_stringa.Text))
            {
                lbl_parole.Text="Le parole sono: 0";
            }
            else
            {
                for(i=0; i < txt_stringa.Text.Length; i++)
                {
                    if (txt_stringa.Text[i] == ' ')
                    {
                        contaparole++;
                    }
                }
                lbl_parole.Text="Le parole sono: " + contaparole;
            }
        }
    }
}
