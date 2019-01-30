using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapyCupOverlay
{
    public partial class OverlayForm : Form
    {
        private Screen mScreen;
        private readonly Label[] mScoreLabels, mDetailLabels;

        public OverlayForm()
        {
            InitializeComponent();

            Screen = Screen.AllScreens.Last();
            mScoreLabels = new[] { mScore0Label, mScore1Label, mScore2Label, mScore3Label };
            mDetailLabels = new[] { mDetails0Label, mDetails1Label, mDetails2Label, mDetails3Label };
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams baseParams = base.CreateParams;

                //baseParams.ExStyle |= 0x08000080;

                return baseParams;
            }
        }

        public Screen Screen
        {
            get {  return mScreen; }
            set
            {
                Location = new Point(value.Bounds.X, value.Bounds.Y + (value.Bounds.Height - Height) / 2);
                Width = value.Bounds.Width;
                mScreen = value;
            }
        }

        public void SetScore(int team, int score)
        {
            mScoreLabels[team].Text = score.ToString();
        }

        public void AppendDetails(int team, string text)
        {
            mDetailLabels[team].Text += text + Environment.NewLine;
        }

        public void ClearDetails()
        {
            for (int i = 0; i < 4; ++i)
                mDetailLabels[i].Text = "";
        }
    }
}
