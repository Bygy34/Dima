using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication3.Control
{
    public class TecnicaControl : Panel

    {
        private int id;
        private IDictionary<int, Technics> TecnicaDictionary;
        private Image setImage;
        private Label VLabel;
        private Label CLabel;
        private Label DWLabel;
        private Label SWLabel;
        private Label TLabel;
        private Label BLabel;
        private Label ALabel;
        private Label BLLabel;
        private Button setButtonOnOff;
        private Button setButtonUP;
        private Button setButtonDown;
        private Button deleteButton;

        public TecnicaControl(int id, IDictionary<int, Technics> TechnicalDictionary)
        {
            this.id = id;
            TecnicaDictionary = TechnicalDictionary;
            Initializer();
        }


        protected void Initializer()
        {
            CssClass = "Panel-div";
            Controls.Add(Span("<h2>" + TecnicaDictionary[id].Name + "</h2><br />"));
            setButtonOnOff = new Button();
            setButtonOnOff.ID = "setButtonOn" + id.ToString();
            if (TecnicaDictionary[id].status == true)
            {
                setButtonOnOff.CssClass = "BotonOf";

            }
            else
            {
                setButtonOnOff.CssClass = "BotonOn";

            }
            setButtonOnOff.Click += SetButtonClickOnOff;
            Controls.Add(setButtonOnOff);


            if (TecnicaDictionary[id] is IChanel)
            {
                setImage = new Image();
                setImage.ID = "setImageC" + id.ToString();
                setImage.ImageUrl = "../Content/телевизор.jpg";
                Controls.Add(setImage);
                Controls.Add(Span("<br />"));
                if (TecnicaDictionary[id].status == true)
                {
                    Controls.Add(Span("Канал : "));
                    string a = ((IChanel)TecnicaDictionary[id]).Chanel;
                    CLabel = Label(a);
                    CLabel.ID = "C" + id.ToString();
                    setButtonUP = new Button();
                    setButtonUP.ID = "setButtonUPC" + id.ToString();
                    setButtonUP.Text = "Следующий";
                    setButtonUP.Click += SetButtonClickChanelNext;
                    setButtonUP.CssClass = "btn btn-small btn-primary bottonos2";
                    setButtonDown = new Button();
                    setButtonDown.ID = "setButtonDownC" + id.ToString();
                    setButtonDown.Text = "Предыдущий";
                    setButtonDown.Click += SetButtonClickChanelPrevious;
                    setButtonDown.CssClass = "btn btn-small btn-primary bottonos2";
                    Controls.Add(CLabel);
                    Controls.Add(Span("<br />"));
                    Controls.Add(setButtonUP);
                    Controls.Add(setButtonDown);
                    Controls.Add(Span("<br />"));
                }
            }

            if (TecnicaDictionary[id] is IBright)
            {
                setImage = new Image();
                setImage.ID = "setImageB" + id.ToString();
                setImage.ImageUrl = "../Content/Холодильник.jpg";
                Controls.Add(setImage);
                Controls.Add(Span("<br />"));
                if (TecnicaDictionary[id].status == true)
                {
                    Controls.Add(Span("Яркость : "));
                    int a = ((IBright)TecnicaDictionary[id]).Bright;
                    BLabel = Label(a);
                    BLabel.ID = "B" + id.ToString();
                    setButtonUP = new Button();
                    setButtonUP.ID = "setButtonUPB" + id.ToString();
                    setButtonUP.Text = "Увеличить";
                    setButtonUP.Click += SetButtonClickBrightUp;
                    setButtonUP.CssClass = "btn btn-small btn-primary bottonos2";
                    setButtonDown = new Button();
                    setButtonDown.ID = "setButtonDownB" + id.ToString();
                    setButtonDown.Text = "Уменьшить";
                    setButtonDown.Click += SetButtonClickBrightDown;
                    setButtonDown.CssClass = "btn btn-small btn-primary bottonos2";
                    Controls.Add(BLabel);
                    Controls.Add(Span("<br />"));
                    Controls.Add(setButtonUP);
                    Controls.Add(setButtonDown);
                    Controls.Add(Span("<br />"));
                }
            }

            if (TecnicaDictionary[id] is ICeilingLamp)
            {
                setImage = new Image();
                setImage.ID = "setImageBL" + id.ToString();
                setImage.ImageUrl = "../Content/Торшер.png";
                Controls.Add(setImage);
                Controls.Add(Span("<br />"));
                if (TecnicaDictionary[id].status == true)
                {
                    Controls.Add(Span("Освещённость : "));
                    int a = ((ICeilingLamp)TecnicaDictionary[id]).BrightLight;
                    BLLabel = Label(a);
                    BLLabel.ID = "BL" + id.ToString();
                    setButtonUP = new Button();
                    setButtonUP.ID = "setButtonUPBL" + id.ToString();
                    setButtonUP.Text = "Увеличить";
                    setButtonUP.Click += SetButtonClickBrightLightUp;
                    setButtonUP.CssClass = "btn btn-small btn - primary bottonos2";
                    setButtonDown = new Button();
                    setButtonDown.ID = "setButtonDownBL" + id.ToString();
                    setButtonDown.Text = "Уменьшить";
                    setButtonDown.Click += SetButtonClickBrightLightDown;
                    setButtonDown.CssClass = "btn btn-small btn-primary bottonos2";
                    Controls.Add(BLLabel);
                    Controls.Add(Span("<br />"));
                    Controls.Add(setButtonUP);
                    Controls.Add(setButtonDown);
                    Controls.Add(Span("<br />"));
                }
            }
            if (TecnicaDictionary[id] is IDirectionWind)
            {
                setImage = new Image();
                setImage.ID = "setImageDW" + id.ToString();
                setImage.ImageUrl = "../Content/Кондиционер.jpg";
                Controls.Add(setImage);
                Controls.Add(Span("<br />"));
                if (TecnicaDictionary[id].status == true)
                {
                    Controls.Add(Span("Направление : "));
                    string a = ((IDirectionWind)TecnicaDictionary[id]).DirectionWind;
                    DWLabel = Label(a);
                    DWLabel.ID = "DW" + id.ToString();
                    setButtonUP = new Button();
                    setButtonUP.ID = "setButtonUPDW" + id.ToString();
                    setButtonUP.Text = "Изменить направление";
                    setButtonUP.Click += SetButtonClickDirectionWindNext;
                    setButtonUP.CssClass = "btn btn-small btn-primary bottonos2";
                    setButtonDown = new Button();
                    setButtonDown.ID = "setButtonDownDW" + id.ToString();
                    setButtonDown.Text = "Изменить направление";
                    setButtonDown.Click += SetButtonClickDirectionWindPrevious;
                    setButtonDown.CssClass = "btn btn-small btn-primary bottonos2";
                    Controls.Add(DWLabel);
                    Controls.Add(Span("<br />"));
                    Controls.Add(setButtonUP);
                    Controls.Add(setButtonDown);
                    Controls.Add(Span("<br />"));
                }
            }

            if (TecnicaDictionary[id] is ITemprich && TecnicaDictionary[id].status == true)
            {
                Controls.Add(Span("Температура : "));
                int a = ((ITemprich)TecnicaDictionary[id]).Temprich;
                TLabel = Label(a);
                TLabel.ID = "T" + id.ToString();
                setButtonUP = new Button();
                setButtonUP.ID = "setButtonUPT" + id.ToString();
                setButtonUP.Text = "Увеличить";
                setButtonUP.Click += SetButtonClickTemprichUp;
                setButtonUP.CssClass = "btn btn-small btn-primary bottonos2";
                setButtonDown = new Button();
                setButtonDown.ID = "setButtonDownT" + id.ToString();
                setButtonDown.Text = "Уменьшить";
                setButtonDown.Click += SetButtonClickTemprichDown;
                setButtonDown.CssClass = "btn btn-small btn-primary bottonos2";
                Controls.Add(TLabel);
                Controls.Add(Span("<br />"));
                Controls.Add(setButtonUP);
                Controls.Add(setButtonDown);
                Controls.Add(Span("<br />"));
            }

            if (TecnicaDictionary[id] is ITrec)
            {
                setImage = new Image();
                setImage.ID = "setImageA" + id.ToString();
                setImage.ImageUrl = "../Content/Магнитофон.jpg";
                Controls.Add(setImage);
                Controls.Add(Span("<br />"));
                if (TecnicaDictionary[id].status == true)
                {
                    Controls.Add(Span("Трек : "));
                    string a = ((ITrec)TecnicaDictionary[id]).Trec;
                    ALabel = Label(a);
                    ALabel.ID = "A" + id.ToString();
                    setButtonUP = new Button();
                    setButtonUP.ID = "setButtonUPA" + id.ToString();
                    setButtonUP.Text = "Следующий";
                    setButtonUP.Click += SetButtonClickAudioPlayerNext;
                    setButtonUP.CssClass = "btn btn-small btn-primary bottonos2";
                    setButtonDown = new Button();
                    setButtonDown.ID = "setButtonDownA" + id.ToString();
                    setButtonDown.Text = "Предыдущий";
                    setButtonDown.Click += SetButtonClickAudioPlayerPrevious;
                    setButtonDown.CssClass = "btn btn-small btn-primary bottonos2";
                    Controls.Add(ALabel);
                    Controls.Add(Span("<br />"));
                    Controls.Add(setButtonUP);
                    Controls.Add(setButtonDown);
                    Controls.Add(Span("<br />"));
                }
            }

            if (TecnicaDictionary[id] is IVolume && TecnicaDictionary[id].status == true)
            {
                Controls.Add(Span("Громкость : "));
                int a = ((IVolume)TecnicaDictionary[id]).Volumes;
                VLabel = Label(a);
                VLabel.ID = "V" + id.ToString();
                setButtonUP = new Button();
                setButtonUP.ID = "setButtonUPV" + id.ToString();
                setButtonUP.Text = "Больше";
                setButtonUP.Click += SetButtonClickVolumeUp;
                setButtonUP.CssClass = "btn btn-small btn-primary bottonos2";
                setButtonDown = new Button();
                setButtonDown.ID = "setButtonDownV" + id.ToString();
                setButtonDown.Text = "Меньше";
                setButtonDown.Click += SetButtonClickVolumeDown;
                setButtonDown.CssClass = "btn btn-small btn-primary bottonos2";
                Controls.Add(VLabel);
                Controls.Add(Span("<br />"));
                Controls.Add(setButtonUP);
                Controls.Add(setButtonDown);
                Controls.Add(Span("<br />"));
            }


            if (TecnicaDictionary[id] is ISpeedWind && TecnicaDictionary[id].status == true)
            {
                Controls.Add(Span("Скорость вертра : "));
                int a = ((ISpeedWind)TecnicaDictionary[id]).SpeedWind;
                SWLabel = Label(a);
                SWLabel.ID = "SW" + id.ToString();
                setButtonUP = new Button();
                setButtonUP.ID = "setButtonUPSW" + id.ToString();
                setButtonUP.Text = "Увеличить";
                setButtonUP.Click += SetButtonClickSpeedWindUp;
                setButtonUP.CssClass = "btn btn-primary bottonos2";
                setButtonDown = new Button();
                setButtonDown.ID = "setButtonDownSW" + id.ToString();
                setButtonDown.Text = "Уменьшить";
                setButtonDown.Click += SetButtonClickSpeedWindDown;
                setButtonDown.CssClass = "btn btn-primary bottonos2";
                Controls.Add(SWLabel);
                Controls.Add(Span("<br />"));
                Controls.Add(setButtonUP);
                Controls.Add(setButtonDown);
                Controls.Add(Span("<br />"));
            }

            Controls.Add(Span("<br />"));

            deleteButton = new Button();
            deleteButton.ID = "d" + id.ToString();
            deleteButton.Text = "Удалить";
            deleteButton.Click += DeleteButtonClick;
            deleteButton.CssClass = "btn bottonos ";
            Controls.Add(deleteButton);

        }
    
       
        protected HtmlGenericControl Span(string innerHTML)
    {
        HtmlGenericControl span = new HtmlGenericControl("span");
        span.InnerHtml = innerHTML;
        return span;
    }

        private Label Label(string b)
        {
            Label Label = new Label();
            Label.Text = b.ToString();
            return Label;
                
        }
        private Image Image (string u)
        {
            Image Image = new Image();
            Image.ImageUrl = u.ToString();
            return Image;

        }

        protected TextBox TextBox(double value)
    {
        TextBox textBox = new TextBox();
        textBox.Text = value.ToString();
        textBox.Columns = 3;
        return textBox;
    }

    protected Label Label(double value)
    {
        Label label = new Label();
        label.Text = value.ToString();
        return label;
    }


        protected void SetButtonClickOnOff(object sender, EventArgs e)
        {
            if (sender == setButtonOnOff)
            {
                if (TecnicaDictionary[id].status == true)
                {
                    TecnicaDictionary[id].status = false;
                }
                else
                {
                    (TecnicaDictionary[id]).status = true;
                }
            }
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickVolumeUp(object sender, EventArgs e)
        {
            ((Volume)TecnicaDictionary[id]).IncreaseVolume();
       //     ((IVolume)TecnicaDictionary[id]).IncreaseVolume();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickVolumeDown(object sender, EventArgs e)
        {
            ((IVolume)TecnicaDictionary[id]).DecreasVolume();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickBrightUp(object sender, EventArgs e)
        {
            ((IBright)TecnicaDictionary[id]).IncreaseBright();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickBrightDown(object sender, EventArgs e)
        {
            ((IBright)TecnicaDictionary[id]).DecreasBright();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickBrightLightUp(object sender, EventArgs e)
        {
            ((ICeilingLamp)TecnicaDictionary[id]).IncreaseBrightLight();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickBrightLightDown(object sender, EventArgs e)
        {
            ((ICeilingLamp)TecnicaDictionary[id]).DecreasBrightLight();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickTemprichUp(object sender, EventArgs e)
        {
            ((ITemprich)TecnicaDictionary[id]).IncreaseTempriche();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickTemprichDown(object sender, EventArgs e)
        {
            ((ITemprich)TecnicaDictionary[id]).DecreasTempriche();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickSpeedWindUp(object sender, EventArgs e)
        {
            ((ISpeedWind)TecnicaDictionary[id]).IncreaseSpeedWind();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickSpeedWindDown(object sender, EventArgs e)
        {
            ((ISpeedWind)TecnicaDictionary[id]).DecreasSpeedWind();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickChanelNext(object sender, EventArgs e)
        {
            ((IChanel)TecnicaDictionary[id]).NextChanel();
            Controls.Clear();
            Initializer();
        }

        protected void SetButtonClickChanelPrevious(object sender, EventArgs e)
        {
            ((IChanel)TecnicaDictionary[id]).PreviousChanel();
            Initializer();
            Controls.Clear();
        }

        protected void SetButtonClickAudioPlayerNext(object sender, EventArgs e)
        {
            ((ITrec)TecnicaDictionary[id]).NextTrec();
            Controls.Clear();
            Initializer();
        }
        protected void SetButtonClickAudioPlayerPrevious(object sender, EventArgs e)
        {
            ((ITrec)TecnicaDictionary[id]).PreviousTrec();
            Controls.Clear();
            Initializer();
        }


        protected void SetButtonClickDirectionWindNext(object sender, EventArgs e)
        {
            ((IDirectionWind)TecnicaDictionary[id]).NextDirectionWind();
            Controls.Clear();
            Initializer();
        }
        protected void SetButtonClickDirectionWindPrevious(object sender, EventArgs e)
        {
            ((IDirectionWind)TecnicaDictionary[id]).PreviousDirectionWind();
            Initializer();
        }

        protected void DeleteButtonClick(object sender, EventArgs e)
    {
            TecnicaDictionary.Remove(id); 
        Parent.Controls.Remove(this);
    }
    }
}