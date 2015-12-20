using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;
using log4net;

namespace Simulacion
{
    public partial class Simulacion : Form
    {
        double HV = double.MaxValue;
        double T, TPLL, NS = 0;
        double TF = 0;
        double IA = 0;
        double Tinic = 0;
        List<double> TPS = new List<double>();
        List<double> TA = new List<double>();
        List<double> STO = new List<double>();
        List<double> ITO = new List<double>();

        int NT = 0;
        double SS, SLL, STA = 0;
        int SPA=0;
        public Simulacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblPPS.Text = "";
            lblPEC.Text = "";
            lblPArr.Text ="";
            lblPTO.Text = "";
            T=0;
            TPLL= 0;
            NS = 0;
            TF = 0;
            IA = 0;
            TPS = new List<double>();
            TA = new List<double>();
            STO = new List<double>();
            ITO = new List<double>();

            NT = 0;
            SS = 0;
            SLL = 0;
            STA = 0;
            SPA = 0;

            int N = Convert.ToInt32(txtCantEmpl.Text);
            int M = Convert.ToInt32(txtCantEmplNuevos.Text);
            
            for (int i=0; i < (Convert.ToInt32(txtCantEmpl.Text) + Convert.ToInt32(txtCantEmplNuevos.Text)); i++) {
                TPS.Add(HV);
                STO.Add(T);
                ITO.Add(0);
                TA.Add(0);
            }

            if (cmbTurnos.Text == "Turno Mañana")
            {
                T = 0; //8 de la mañana en segundos}
                Tinic = T;
                TPLL = T;
                TF = 21600; //14 de la tarde en segundos
            }
            else {
                T = 0;
                Tinic = T;
                TPLL = T;
                TF = 21600; //20 de la noche en segundos
            }

            while (T <= TF || (T > TF && NS>0)) {
                int menorTPS = buscarMenorSalida(N, M);
                
                if (TPS[menorTPS] < TPLL)
                {
                    realizarSalida(menorTPS, N, M);
                }
                else
                {
                    realizarLlegada(N, M);
                }

                if (T > TF) {
                    TPLL = HV; 
                }

            }

            imprimirResultados(N, M);

   

        }

        private void imprimirResultados(int N, int M)
        {
            lblPPS.Text = (Math.Round((SS - SLL) / NT,2)).ToString();
            lblPEC.Text = (Math.Round((SS - SLL - STA) / NT, 2)).ToString();
            lblPArr.Text = ((SPA*100) / (NT+SPA)).ToString();
            for (int i=0; i < TPS.Count; i++) {
                double sto = (STO[i]==0) ? T : STO[i];
                lblPTO.Text += "Puesto nro " + (i + 1) + ", PTO: " + Math.Round((sto * 100 / T), 2).ToString() + "\n\r";
            }
            lblCantCli.Text = NT.ToString();
        }

        private void realizarLlegada(int N, int M)
        {
            T = TPLL;
            IA = calcularIA();
            TPLL = T + IA;
            bool Arr = RealizarArrepentimiento(N, M);

            if (Arr == false) {
                NS = NS + 1;
                SLL = SLL + T;
                if (NS <= N + M) {
                    int puesto = buscarPuesto();
                    STO[puesto] = STO[puesto] + (T - ITO[puesto]);
                    TA[puesto] = calcularTA(M);
                    TPS[puesto] = T + TA[puesto];
                    STA = STA + TA[puesto];
                }
            }

        }

        private int buscarPuesto()
        {
            int posicionPuestoHV = TPS.IndexOf(TPS.Find(x => x == HV));
            int mayorOcioso = posicionPuestoHV;
            for (int j = 0; j < TPS.Count; j++) {
                if (TPS[j] == HV) {
                    if (STO[j] == 0) {
                        mayorOcioso = j;
                        return mayorOcioso;
                    }
                    else {
                        mayorOcioso= STO.IndexOf(STO.Find(y => (y == STO.Max() && TPS[STO.IndexOf(y)] == HV)));
                        //myList.FindAll(x => (x.StartTime <= minDateToReturn && x.EndTime >= maxDateToReturn):
                    }
                }
            }
            return mayorOcioso;

        }

        private bool RealizarArrepentimiento(int N, int M)
        {
            if (NS-1 > 3+N+M) {
                double R = dameRandom();
                if (R < 40) {
                    SPA++;
                    return true;
                }
            }
            return false;
        }

        private double calcularIA()
        {
            double R = dameRandom();
            if (cmbTurnos.Text == "Turno Tarde")
            {
                return new LogNormal(4.9074, 1.0703).Sample();
                //return new Gamma(1.1804, 179).InverseCumulativeDistribution(R/100);
            }
            else {
                return new LogNormal(4.9788, 1.0368).Sample();
                //return new LogNormal(4.9788, 1.0368).InverseCumulativeDistribution(R/100);
            }
        }

        private void realizarSalida(int menorTPS, int N, int M)
        {
            T = TPS[menorTPS];
            NS = NS - 1;
            if (NS >= N + M)
            {
                TA[menorTPS] = calcularTA(M);
                TPS[menorTPS] = T + TA[menorTPS];
                STA = STA + TA[menorTPS];
            }
            else {
                ITO[menorTPS] = T;
                TPS[menorTPS] = HV;
            }

            SS = SS + T;
            NT = NT + 1;

        }

        private double calcularTA(int M)
        {
            double OS = 25;
            double R = dameRandom();

            if (R <= OS)
            {
                //OBRA SOCIAL
                return new Normal(323.19, 183.3).Sample() + M*60;
                //return new Normal(323.19, 183.3).InverseCumulativeDistribution(R/100) + M * 60;
            }
            else { 
                //PARTICULAR
                return new Weibull(1.5565, 100.47).Sample() + M * 60;
                //return new Gamma(1.7458, 54.354).InverseCumulativeDistribution(R/100) + M * 60;
            }
        }

        private static double dameRandom()
        {
            Random rnd = new Random();
            double R = rnd.Next(1, 101);
            return R;
        }

        private int buscarMenorSalida(int N, int M)
        {
            return TPS.IndexOf(TPS.Min());
        }

    }
}
