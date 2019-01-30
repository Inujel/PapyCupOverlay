using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using PpApplication = Microsoft.Office.Interop.PowerPoint.Application;

namespace PapyCupOverlay
{
   public partial class ControlForm : Form
   {
      private readonly OverlayForm mOverlay = new OverlayForm();
      private readonly TextBox[] mScoreBoxes;
      private readonly Question[] mQuestions = Question.Questions;
      private Question mCurrent;
      private int mQuestionIndex;

      private const string PresentationFile = @"C:\Users\julie\Desktop\BR.pptx";

      private readonly PpApplication mPowerPoint;
      private readonly Presentation mPresentation;

      public ControlForm()
      {
         InitializeComponent();

         mScoreBoxes = new[] { mScore0Box, mScore1Box, mScore2Box, mScore3Box };

         mOverlay.SetScore(0, 0);
         mOverlay.SetScore(1, 0);
         mOverlay.SetScore(2, 0);
         mOverlay.SetScore(3, 0);
         mOverlay.ClearDetails();

         SelectQuestion(0);

         mPowerPoint = new PpApplication();
         mPresentation = mPowerPoint.Presentations.Open(PresentationFile);

         mPresentation.SlideShowSettings.Run();
      }

      protected override void OnFormClosed(FormClosedEventArgs e)
      {
         base.OnFormClosed(e);

         mPresentation.Close();
      }

      void ShowHideButtonClick(object sender, EventArgs e)
      {
         if (mOverlay.Visible)
         {
            mOverlay.Hide();
            mOverlay.Show();
            mOverlay.Hide();
            mPresentation.SlideShowWindow.Activate();
         }
         else
         {
            mOverlay.Show();
         }
      }

      void ControlFormLocationChanged(object sender, EventArgs e)
      {
         if (Screen.AllScreens.Length > 1)
         {
            Screen mainScreen = Screen.FromPoint(Location);
            mOverlay.Screen = Screen.AllScreens.First(s => s.Bounds != mainScreen.Bounds);
         }
      }

      void TopMostBoxCheckedChanged(object sender, EventArgs e)
      {
         mOverlay.TopMost = TopMost = mTopMostBox.Checked;
      }

      private void mScore0Box_TextChanged(object sender, EventArgs e)
      {
         try
         {
            mOverlay.SetScore(0, int.Parse(mScore0Box.Text));
         }
         catch
         {
         }
      }

      private void mScore1Box_TextChanged(object sender, EventArgs e)
      {
         try
         {
            mOverlay.SetScore(1, int.Parse(mScore1Box.Text));
         }
         catch
         {
         }
      }

      private void mScore2Box_TextChanged(object sender, EventArgs e)
      {
         try
         {
            mOverlay.SetScore(2, int.Parse(mScore2Box.Text));
         }
         catch
         {
         }
      }

      private void mScore3Box_TextChanged(object sender, EventArgs e)
      {
         try
         {
            mOverlay.SetScore(3, int.Parse(mScore3Box.Text));
         }
         catch
         {
         }
      }

      void SelectQuestion(int index)
      {
         mCurrent = mQuestions[index];
         mQuestionIndex = index;

         mOverlay.ClearDetails();

         mQuestionLabel.Text = "Question " + (index + 1) + ": " + mQuestions[index].Title;

         for (int i = 0; i < mCurrent.Items.Count; ++i)
         {
            Control titleLabel = mTable.GetControlFromPosition(0, i + 2);

            if (titleLabel == null)
            {
               titleLabel = new Label();
               mTable.Controls.Add(titleLabel, 0, i + 2);

               for (int j = 0; j < 4; ++j)
               {
                  Button button = new Button();
                  button.Text = "+";
                  button.Margin = new Padding(0);
                  button.Click += ButtonOnClick;
                  button.Tag = new Tuple<int, int>(i, j);
                  mTable.Controls.Add(button, j + 1, i + 2);
               }
            }

            for (int j = 0; j < 4; ++j)
               mTable.GetControlFromPosition(j + 1, i + 2).Enabled = true;

            titleLabel.Text = mCurrent.Items[i].Item1;
         }

         for (int i = mQuestions[index].Items.Count; i < mTable.RowCount; ++i)
         {
            Control ctl = mTable.GetControlFromPosition(0, i + 2);
            if (ctl != null)
               ctl.Text = "";

            for (int j = 0; j < 4; ++j)
            {
               if (mTable.GetControlFromPosition(j + 1, i + 2) != null)
                  mTable.GetControlFromPosition(j + 1, i + 2).Enabled = false;
            }
         }
      }

      private void ButtonOnClick(object sender, EventArgs eventArgs)
      {
         Button button = (Button)sender;
         Tuple<int, int> ij = (Tuple<int, int>)button.Tag;
         int team = ij.Item2;
         int index = ij.Item1;
         int score = int.Parse(mScoreBoxes[team].Text);
         int increment = mCurrent.GoodAnswer(index);
         score += increment;
         mScoreBoxes[team].Text = score.ToString();
         button.Enabled = false;

         mOverlay.AppendDetails(team, string.Format("{0} +{1}", mCurrent.Items[index].Item1, increment));
      }

      private void mPreviousButton_Click(object sender, EventArgs e)
      {
         if (mQuestionIndex > 0)
         {
            SelectQuestion(mQuestionIndex - 1);
            mPresentation.SlideShowWindow.View.Previous();
            mOverlay.Hide();
         }
      }

      private void mNextButton_Click(object sender, EventArgs e)
      {
         if (mQuestionIndex < mQuestions.Length - 1)
         {
            SelectQuestion(mQuestionIndex + 1);
            mPresentation.SlideShowWindow.View.Next();
            mOverlay.Hide();
         }
      }

      private void NextSlideClick(object sender, EventArgs e)
      {
         mPresentation.SlideShowWindow.View.Next();
      }

      private void PreviousSlideClick(object sender, EventArgs e)
      {
         mPresentation.SlideShowWindow.View.Previous();
      }
   }

}
