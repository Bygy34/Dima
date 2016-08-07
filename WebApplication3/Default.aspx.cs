using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Control;
using WebApplication3.Models;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        private IDictionary<int, Technics> TechnicalDictionary;
        protected void Page_Init(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                TechnicalDictionary = (SortedDictionary<int, Technics>)Application["Technica"];
            }
            else
            {
                TechnicalDictionary = new SortedDictionary<int, Technics>();
                TechnicalDictionary.Add(1, new TV("TV", 10,Chanel.M1, false));
                TechnicalDictionary.Add(2, new AudioPlayer("Магнитофон", 13, Music.trec1, false));
                TechnicalDictionary.Add(3, new AirConditioner("Кондиционер", 28, 2, DirectionWind.down, false));
                TechnicalDictionary.Add(4, new Refrigerator("Холодильник", 7, false, 30));
                TechnicalDictionary.Add(5, new CeilingLamp("Торшер", 100, false));
                Application["Technica"] = TechnicalDictionary;
                Application["ID"] = 6;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            InitialiseTecnicaPanel();
            if (IsPostBack)
            {
                addTecnicaButton.Click += addTecnicaButtonClick;
                ToWork.Click += ToWorkClick;
                FromWork.Click += FromWorkClick;
                Day.Click += DayClick;
                Night.Click += NightClick;
                SwitchOff.Click += SwitchOffClick;
            }
            
        }

        protected void InitialiseTecnicaPanel()
        {
            foreach (int key in TechnicalDictionary.Keys)
            {
                tecnicaPanel.Controls.Add(new TecnicaControl(key, TechnicalDictionary));
            }
        }

        public void addTecnicaButtonClick(object sender, EventArgs e)
        {
            Technics newTecnica;
            switch (dropDownTecnicaList.SelectedIndex)
            {
                default:
                    newTecnica = new Refrigerator("Холодильник", 7, false, 30);                    
                    break;
                case 1:
                    newTecnica = new AudioPlayer("Магнитофон", 13, Music.trec1, false);
                    break;
                case 2:
                    newTecnica = new TV("TV", 10, Chanel.inter, false);
                    break;
                case 3:
                    newTecnica = new AirConditioner("Кондиционер", 28, 2, DirectionWind.down, false);
                    break;

                case 4:
                    newTecnica = new AirConditioner("Вентиляция", 28, 3, DirectionWind.down, false);
                    break;
                case 5:
                    newTecnica = new CeilingLamp("Люстра", 80, true);
                    break;
            }
            int id = (int)Application["ID"];
            TechnicalDictionary.Add(id, newTecnica);
            tecnicaPanel.Controls.Add(new TecnicaControl(id, TechnicalDictionary));
            id++;
            Application["ID"] = id;

        }
        public void ToWorkClick(object sender, EventArgs e)
        {
            foreach (int key in TechnicalDictionary.Keys)
            {
                TechnicalDictionary[key].status = false;
                if(TechnicalDictionary[key] is Refrigerator )
                { TechnicalDictionary[key].status = true; }
            }
            tecnicaPanel.Controls.Clear();
            InitialiseTecnicaPanel();
        }
        public void SwitchOffClick(object sender, EventArgs e)
        {
            foreach (int key in TechnicalDictionary.Keys)
            {
                TechnicalDictionary[key].status = false;
            }
            tecnicaPanel.Controls.Clear();
            InitialiseTecnicaPanel();
        }
        public void NightClick(object sender, EventArgs e)
        {
            foreach (int key in TechnicalDictionary.Keys)
            {
                TechnicalDictionary[key].status = false;
                if (TechnicalDictionary[key] is Refrigerator)
                { TechnicalDictionary[key].status = true; }
                if (TechnicalDictionary[key] is CeilingLamp)
                { TechnicalDictionary[key].status = true;
                 ((CeilingLamp)TechnicalDictionary[key]).GetBrightLight=0;
                }
            }
            tecnicaPanel.Controls.Clear();
            InitialiseTecnicaPanel();
        }
        public void DayClick(object sender, EventArgs e)
        {
            foreach (int key in TechnicalDictionary.Keys)
            {
                TechnicalDictionary[key].status = false;
                if (TechnicalDictionary[key] is Refrigerator)
                { TechnicalDictionary[key].status = true; }
                if(TechnicalDictionary[key] is CeilingLamp)
                { ((CeilingLamp)TechnicalDictionary[key]).GetBrightLight = 25; }
                
            }
            tecnicaPanel.Controls.Clear();
            InitialiseTecnicaPanel();

        }
        public void FromWorkClick(object sender, EventArgs e)
        {
            foreach (int key in TechnicalDictionary.Keys)
            {
                TechnicalDictionary[key].status = false;
                if(TechnicalDictionary[key] is Refrigerator)
                {
                    ((Refrigerator)TechnicalDictionary[key]).status = true;
                    ((Refrigerator)TechnicalDictionary[key]).GetTempriche = 28;
                }
                if (TechnicalDictionary[key] is CeilingLamp)
                {
                    ((CeilingLamp)TechnicalDictionary[key]).GetBrightLight = 50;
                }
                if (TechnicalDictionary[key] is AudioPlayer)
                {
                    ((AudioPlayer)TechnicalDictionary[key]).status = true;
                }
                if(TechnicalDictionary[key] is AirConditioner)
                {
                    ((AirConditioner)TechnicalDictionary[key]).status = true;
                    ((AirConditioner)TechnicalDictionary[key]).GetSpeedWind = 3;
                    ((AirConditioner)TechnicalDictionary[key]).GetTempriche = 28;
                }

            }
            tecnicaPanel.Controls.Clear();
            InitialiseTecnicaPanel();
        }


        }
}
