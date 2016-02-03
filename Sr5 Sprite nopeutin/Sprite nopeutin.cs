using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sr5_Sprite_nopeutin
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int osumat = 0;
            int heitto = 0;
            // int pj = 0;
            List<int> integers = new List<int>();
            List<int> pj_lista = new List<int>();
            List<int> soakki = new List<int>();
            List<int> soakki2 = new List<int>();
            List<int> rekister = new List<int>();
            List<int> pj_lista2 = new List<int>();
            int pj_osumat = 0;
            int pj_osumat2 = 0;
            int soakki_osumat = 0;
            int soakki_osumat2 = 0;
            int rekisteri_osumat = 0;
            int nettohitit2 = 0;
            for (int i = 0; i < compileValue.Value; i++)
            {
                heitto = FDL.Library.Numeric.RandomNumber.Between(1, 6);
                //  heitto = rnd.Next(1, 7); // 1-6
                integers.Add(heitto);
                if (heitto >= 5)
                {
                    osumat++;
                }
            }
            for (int i = 0; i < levelValue.Value; i++)
            {
                heitto = FDL.Library.Numeric.RandomNumber.Between(1, 6);
                pj_lista.Add(heitto);
                if (heitto >= 5)
                {
                    pj_osumat++;
                }
            }
            for (int i = 0; i < soakValue.Value; i++)
            {
                heitto = FDL.Library.Numeric.RandomNumber.Between(1, 6);
                soakki.Add(heitto);
                if (heitto >= 5)
                {
                    soakki_osumat++;
                }
            }
            for (int i = 0; i < registerValue.Value; i++)
            {
                heitto = FDL.Library.Numeric.RandomNumber.Between(1, 6);
                rekister.Add(heitto);
                if (heitto >= 5)
                {
                    rekisteri_osumat++;
                }
            }
            for (int i = 0; i < 2 * levelValue.Value; i++)
            {
                heitto = FDL.Library.Numeric.RandomNumber.Between(1, 6);
                pj_lista2.Add(heitto);
                if (heitto >= 5)
                {
                    pj_osumat2++;
                }
            }
            for (int i = 0; i < soakValue.Value; i++)
            {
                heitto = FDL.Library.Numeric.RandomNumber.Between(1, 6);
                soakki2.Add(heitto);
                if (heitto >= 5)
                {
                    soakki_osumat2++;
                }
            }
            string heitot = String.Join(",", integers);
            string pjHeitot = String.Join(",", pj_lista);
            string soakkiHeitot = String.Join(",", soakki);
            string soakkiHeitot2 = String.Join(",", soakki);
            string rekisteriHeitot = String.Join(",", rekister);
            string pjHeitot2 = String.Join(",", pj_lista2);
            if (osumat > 6)
            {
                osumat = 6;
            }
            if (rekisteri_osumat > 6)
            {
                rekisteri_osumat = 6;
            }
            int nettohitit = osumat - pj_osumat;

            nettohitit2 = rekisteri_osumat - pj_osumat2;
            int damage = pj_osumat - soakki_osumat;
            // soakki_osumat = pj_osumat - soakki_osumat;
            int damage2 = (2 * pj_osumat2) - soakki_osumat2;
            // soakki_osumat2 = damage - soakki_osumat2;
            if (damage < 0)
            {
                damage = 0;
            }
            if (damage2 < 0)
            {
                damage2 = 0;
            }
            if (nettohitit < 0)
            {
                nettohitit = 0;
            }
            if (nettohitit2 < 0)
            {
                nettohitit2 = 0;
            }

            if (nettohitit > 0 && nettohitit2 > 0)
            {
                damage = damage + damage2;
                nettohitit = nettohitit + nettohitit2 - 1;
                MessageBox.Show("Osumia tuli: " + osumat + "\nPj:n osumat: " + pj_osumat + "\nRekisteri osumat: " + rekisteri_osumat + "\nPj:n rekisteri osumat: " + pj_osumat2 + "\nCompile soakki: " + soakki_osumat + "\nRekisteri soakki: " + soakki_osumat2 + "\nRekisteröit spriten jolla on: " + nettohitit + " taskia." + "\nStun damagea tuli (soakin jälkeen): " + damage, "Onnistui!");
            }
            else if (nettohitit > 0 && nettohitit2 == 0)
            {
                nettohitit = nettohitit - 1;
                MessageBox.Show("Osumia tuli: " + osumat + "\nPj:n osumat: " + pj_osumat + "\nCompile soakki: " + soakki_osumat + "\nCompilattu sprite jolla on vielä: " + nettohitit + " taskia" + "\nStun damagea tuli (soakin jälkeen): " + damage, "Compile onnistui, rekisteröinti ei");
            }
            else
            {
                MessageBox.Show("Failed Compiling!", "Failure!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace FDL.Library.Numeric
{
    public static class RandomNumber
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int Between(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // We are using Math.Max, and substracting 0.00000000001, 
            /// to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // We need to add one to the range, to allow for the rounding done with Math.Floor
            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimumValue + randomValueInRange);
        }
    }
}

