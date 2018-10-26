using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hetutarkistin
{
    public class TarkistaHenkilotunnus
    {
        public static bool TarkistaHetu(string hetu, out string virheilmoitus)
        {
            hetu.Trim();

            // Hetun pituus
            if (hetu.Length > 11 || hetu.Length < 11)
            {
                virheilmoitus = "Hetu liian lyhyt.";
                return false;
            }

            // Kirjaimia tms väärissä paikoissa
            int ignore = 0;
            if (!int.TryParse(hetu.Substring(0, 6), out ignore))
            {
                virheilmoitus = "Syntymäajassa ei voi olla kirjaimia.";
                return false;
            }

            if (!int.TryParse(hetu.Substring(7, 3), out ignore))
            {
                virheilmoitus = "Yksilönumerossa ei voi olla kirjaimia.";
                return false;
            }

            // Väärä viimeinen merkki
            string pvm = hetu.Substring(0, 6);
            string syntymanumero = hetu.Substring(7, 3);

            string hetuTarkisteet = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            char tarkistemerkki = hetu[10];
            tarkistemerkki = char.ToUpper(tarkistemerkki); // jos tarkistekirjain on annettu pienellä.

            int jakojaannos = int.Parse(pvm + syntymanumero) % 31;
            if (hetuTarkisteet[jakojaannos] != tarkistemerkki)
            {
                virheilmoitus = "Tarkistemerkki ei ole oikein.";
                return false;
            }

            // Vuosimerkki
            string tarkistusmerkki = hetu.Substring(6, 1);
            string vuosi;
            switch (tarkistusmerkki)
            {
                case "A":
                    vuosi = "20" + hetu.Substring(4, 2);
                    break;
                case "-":
                    vuosi = "19" + hetu.Substring(4, 2);
                    break;
                case "+":
                    vuosi = "18" + hetu.Substring(4, 2);
                    {
                        virheilmoitus = "Henkilö ei voi olla syntynyt 1800-luvulla.";
                        return false;
                    }

                // yhtään 1800-luvulla syntynyttä suomalaista ei ole enää elossa, joten tässä voi turvallisesti palauttaa false.
                default:
                    {
                        virheilmoitus = "Virheellinen vuosisadan tunnus.";
                        return false;
                    }
            }

            // Liian suuret tai pienet arvot
            int pp = Convert.ToInt32(hetu.Substring(0, 2));
            int kk = Convert.ToInt32(hetu.Substring(2, 2));
            int vv = Convert.ToInt32(vuosi);

            if (kk > 12 || kk < 1)
            {
                virheilmoitus = "Kuukausi vääränmuotoinen.";
                return false;
            }
            if (vv > DateTime.Today.Year || vv < DateTime.Today.Year - 115)
            // Ei voi olla syntynyt tulevaisuudessa.
            // Lisäksi yksikään suomalainen ei ole elänyt 115-vuotiaaksi tai vanhemmaksi.
            {
                virheilmoitus = "Kuukausi vääränmuotoinen.";
                return false;
            }

            // Tarkistetaan kuukausien pituudet
            if (kk == 2)
            {
                if (DateTime.IsLeapYear(vv))
                {
                    if (pp > 29 || pp < 1)
                    {
                        virheilmoitus = "Päivä vääränmuotoinen.";
                        return false;
                    }
                }
                else if (pp > 28 || pp < 1)
                {
                    virheilmoitus = "Päivä vääränmuotoinen.";
                    return false;
                }
            }
            else if (kk == 4 || kk == 6 || kk == 9 || kk == 11)
            {
                if (pp > 30 || pp < 1)
                {
                    virheilmoitus = "Päivä vääränmuotoinen.";
                    return false;
                }
            }
            else
            {
                if (pp > 31 || pp < 1)
                {
                    virheilmoitus = "Päivä vääränmuotoinen.";
                    return false;
                }
            }

            virheilmoitus = "Kaikki kunnossa!";
            return true;
        }

    }
}
