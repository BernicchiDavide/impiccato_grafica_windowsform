using System.Drawing.Drawing2D;

namespace Impiccato_Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random random = new Random();
        static string parola;
        static char[] ris;
        static bool lool = true;
        static bool check = false;
        static int vite = 0;
        static int ten = 0;
        static int ten1 = 0;
        static int punte = 0;
        static int tentativi = 0;

        void disable_all()
        {
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            E.Enabled = false;
            F.Enabled = false;
            G.Enabled = false;
            H.Enabled = false;
            I.Enabled = false;
            L.Enabled = false;
            M.Enabled = false;
            N.Enabled = false;
            K.Enabled = false;
            J.Enabled = false;
            O.Enabled = false;
            P.Enabled = false;
            Q.Enabled = false;
            R.Enabled = false;
            S.Enabled = false;
            T.Enabled = false;
            U.Enabled = false;
            V.Enabled = false;
            W.Enabled = false;
            X.Enabled = false;
            Y.Enabled = false;
            Z.Enabled = false;
            reroll.Enabled = false;
            hpup.Enabled = false;
            ind.Enabled = false;
            BParolaImp.Enabled = false;
            BProvaP.Enabled = false;
            txtParola.Enabled = false;
        }
        void enable_in()
        {
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            E.Enabled = true;
            F.Enabled = true;
            G.Enabled = true;
            H.Enabled = true;
            I.Enabled = true;
            L.Enabled = true;
            M.Enabled = true;
            N.Enabled = true;
            K.Enabled = true;
            J.Enabled = true;
            O.Enabled = true;
            P.Enabled = true;
            Q.Enabled = true;
            R.Enabled = true;
            S.Enabled = true;
            T.Enabled = true;
            U.Enabled = true;
            V.Enabled = true;
            W.Enabled = true;
            X.Enabled = true;
            Y.Enabled = true;
            Z.Enabled = true;
            reroll.Enabled = true;
            hpup.Enabled = true;
            ind.Enabled = true;
            BProvaP.Enabled = true;
            txtParola.Enabled = true;
        }
        void end_screan_badend()
        {
            disable_all();
            BParolaImp.Enabled = true;
            endtitlelbl.BackColor = Color.White;
            endtitlelbl.Text = "HAI ESAURITO LE VITE. scegliere una nuova diffiolta";
            dif.Enabled = true;
            dif2.Enabled = true;
            dif3.Enabled = true;
        }
        void end_screan_mid()
        {
            disable_all();
            endtitlelbl.BackColor = Color.White;
            ten = ten1;
            tent.Text = "Tentativi: " + ten; ;
            endtitlelbl.Text = "LA PAROLA ERA: " + parola + "  -hai finito i tentativi";
            BParolaImp.Enabled = true;

        }
        void hp_down()
        {
            vite -= 1;
            vit.Text = "Vite: " + vite.ToString();
            disable_all();
            end_screan_mid();
            if (vite <= 0)
            {
                end_screan_badend();
            }
        }
        void inp_lettera(char c)
        {
            check = false;
            lool = true;
            for (int i = 1; i < parola.Length; i++)
            {
                if (parola[i] == c)
                {
                    ris[i] = c;
                    check = true;
                    v_f.Text = "esatto!";
                }
            }
            if (check == false)
            {
                ten -= 1;
                tentativi += 1;
                tent.Text = "Tentativi: " + ten.ToString();
                v_f.Text = "sbagliato";
                if (ten <= 0)
                {
                    hp_down();
                }
            }
            LblParola.Text = parola[0].ToString() + " ";
            for (int i = 1; i < parola.Length; i++)
            {
                LblParola.Text += ris[i] + " ";
            }
            for (int i = 1; i < parola.Length; i++)
            {
                if (ris[i] == '_')
                {
                    lool = false;
                }
            }
            if (lool == true)
            {
                win.Text = "HAI VINTOOO!!";
                l1.Text = "la parola precedente era: " + parola;
                punte += parola.Length - (tentativi / 2);
                pun.Text = "Punteggio: " + punte.ToString();
                listP.Items.Add(parola);
                disable_all();
                BParolaImp.Enabled = true;
            }
        }
        private void BParolaImp_Click(object sender, EventArgs e)
        {
            ten = ten1;
            tent.Text = "Tentativi: " + ten;
            endtitlelbl.Text = " ";
            BParolaImp.Enabled = false;
            string par = "ParoleImpiccato.Grafica.txt";
            StreamReader sr = new StreamReader(par);
            string line = sr.ReadLine();
            int ran = random.Next(0, 101);
            for (int i = 0; i < ran; i++)
            {
                line = sr.ReadLine();
                parola = line;
            }
            enable_in();
            ris = new char[parola.Length];
            win.Text = " ";
            for (int i = 0; i < parola.Length; i++)
            {
                ris[i] = '_';
            }
            LblParola.Text = parola[0].ToString() + " ";
            for (int i = 0; i < parola.Length - 1; i++)
            {
                LblParola.Text += ris[i] + " ";
            }
        }
        private void A_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            inp_lettera('A');
        }

        private void B_Click(object sender, EventArgs e)
        {
            B.Enabled = false;
            inp_lettera('B');
        }

        private void C_Click(object sender, EventArgs e)
        {
            C.Enabled = false;
            inp_lettera('C');
        }

        private void D_Click(object sender, EventArgs e)
        {
            D.Enabled = false;
            inp_lettera('D');
        }

        private void E_Click(object sender, EventArgs e)
        {
            E.Enabled = false;
            inp_lettera('E');
        }

        private void F_Click(object sender, EventArgs e)
        {
            F.Enabled = false;
            inp_lettera('F');
        }

        private void G_Click(object sender, EventArgs e)
        {
            G.Enabled = false;
            inp_lettera('G');
        }

        private void H_Click(object sender, EventArgs e)
        {
            H.Enabled = false;
            inp_lettera('H');
        }

        private void I_Click(object sender, EventArgs e)
        {
            I.Enabled = false;
            inp_lettera('I');
        }

        private void T_Click(object sender, EventArgs e)
        {
            T.Enabled = false;
            inp_lettera('T');
        }

        private void O_Click(object sender, EventArgs e)
        {
            O.Enabled = false;
            inp_lettera('O');
        }

        private void J_Click(object sender, EventArgs e)
        {
            J.Enabled = false;
            inp_lettera('J');
        }

        private void K_Click(object sender, EventArgs e)
        {
            K.Enabled = false;
            inp_lettera('K');
        }

        private void L_Click(object sender, EventArgs e)
        {
            L.Enabled = false;
            inp_lettera('L');
        }

        private void M_Click(object sender, EventArgs e)
        {
            M.Enabled = false;
            inp_lettera('M');
        }

        private void N_Click(object sender, EventArgs e)
        {
            N.Enabled = false;
            inp_lettera('N');
        }

        private void P_Click(object sender, EventArgs e)
        {
            P.Enabled = false;
            inp_lettera('P');
        }

        private void Q_Click(object sender, EventArgs e)
        {
            Q.Enabled = false;
            inp_lettera('Q');
        }

        private void R_Click(object sender, EventArgs e)
        {
            R.Enabled = false;
            inp_lettera('R');
        }

        private void S_Click(object sender, EventArgs e)
        {
            S.Enabled = false;
            inp_lettera('S');
        }

        private void U_Click(object sender, EventArgs e)
        {
            U.Enabled = false;
            inp_lettera('U');
        }

        private void V_Click(object sender, EventArgs e)
        {
            V.Enabled = false;
            inp_lettera('V');
        }
        private void W_Click(object sender, EventArgs e)
        {
            W.Enabled = false;
            inp_lettera('W');
        }

        private void X_Click(object sender, EventArgs e)
        {
            X.Enabled = false;
            inp_lettera('X');
        }

        private void Y_Click(object sender, EventArgs e)
        {
            Y.Enabled = false;
            inp_lettera('Y');
        }

        private void Z_Click(object sender, EventArgs e)
        {
            Z.Enabled = false;
            inp_lettera('Z');
        }
        private void BProvaP_Click(object sender, EventArgs e)
        {
            if (txtParola.Text.ToUpper() == parola)
            {
                LblParola.Text = " ";
                for (int i = 0; i < parola.Length; i++)
                {
                    LblParola.Text += parola[i] + " ";
                }
                win.Text = "HAI VINTOOO!!";
                l1.Text = "la parola precedente era: " + parola;
                punte += parola.Length-(tentativi/2);
                pun.Text = "Punteggio: " + punte.ToString();
                listP.Items.Add(parola);
                disable_all();
                BParolaImp.Enabled = true;
            }
            else
            {
                l1.Text = "la parola precedente era: " + parola;
                tent.Text = "Tentativi: " + ten.ToString();
                endtitlelbl.Text = "LA PAROLA ERA: " + parola + " -1 vita";
                hp_down();
                disable_all();
                BParolaImp.Enabled = true;
                listP.Items.Add(parola);
            }
        }

        private void dif_Click(object sender, EventArgs e)
        {
            dif2.Enabled = false;
            dif.Enabled = false;
            dif3.Enabled = false;
            vite = 5;
            ten1 = 15;
            ten = 15;
            indi = 10;
            hup = 5;
            dsix = 9999999;
            reroll.Text = "Re Roll: " + dsix;
            hpup.Text = "HP UP: " + hup;
            ind.Text = "Indizzi: " + indi;
            BParolaImp.Enabled = true;
            tent.Text = "Tentativi: " + ten;
            vit.Text = "Vite: " + vite;
            endtitlelbl.Text = " ";
        }

        private void dif2_Click(object sender, EventArgs e)
        {
            dif3.Enabled = false;
            dif2.Enabled = false;
            dif.Enabled = false;
            vite = 3;
            ten1 = 10;
            ten = 10;
            indi = 5;
            hup = 5;
            dsix = 7;
            reroll.Text = "Re Roll: " + dsix;
            hpup.Text = "HP UP: " + hup;
            ind.Text = "Indizzi: " + indi;
            BParolaImp.Enabled = true;
            tent.Text = "Tentativi: " + ten;
            vit.Text = "Vite: " + vite;
            endtitlelbl.Text = " ";
        }

        private void dif3_Click(object sender, EventArgs e)
        {
            dif2.Enabled = false;
            dif3.Enabled = false;
            vite = 2;
            ten1 = 5;
            ten = 5;
            indi = 5;
            hup = 3;
            dsix = 5;
            reroll.Text = "Re Roll: " + dsix;
            hpup.Text = "HP UP: " + hup;
            ind.Text = "Indizzi: " + indi;
            BParolaImp.Enabled = true;
            tent.Text = "Tentativi: " + ten;
            vit.Text = "Vite: " + vite;
            endtitlelbl.Text = " ";
        }

        private void listP_SelectedIndexChanged(object sender, EventArgs e)
        {
            listP.Items.Add("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static int indi = 0;
        static int hup = 0;
        static int dsix = 0;

        private void ind_Click(object sender, EventArgs e)
        {
            indi -= 1;
            bool illsm = true;
            int i = 0;
            if (indi > 0)
            {
                while(illsm==true)
                {
                    i++;
                    if (ris[i] == '_')
                    {
                        inp_lettera(parola[i]);
                        ind.Text = "Indizzi: " + indi;
                        illsm = false;
                    }
                }
            }
            else
            {
                ind.Text = "Indizzi: X";
            }
        }

        private void reroll_Click(object sender, EventArgs e)
        {
            dsix -= 1;
            if (dsix > 0)
            {
                BParolaImp_Click(sender, e);
                reroll.Text = "Re Roll: " + dsix;
            }
            else
            {
                reroll.Text = "Re Roll: X";
            }
        }

        private void hpup_Click(object sender, EventArgs e)
        {
            hup -= 1;

            if (hup > 0)
            {
                ten = ten1;
                tent.Text= "Tentativi: " + ten;
                hpup.Text = "HP UP: " + hup ;
            }
            else
            {
                hpup.Text = "HP UP: X";
            }
        }
    }
}
