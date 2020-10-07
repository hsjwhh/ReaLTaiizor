﻿#region Imports

using System;
using System.Drawing;
using System.Security;
using System.Reflection;
using ReaLTaiizor.Colors;
using System.Windows.Forms;
using System.ComponentModel;

#endregion

namespace ReaLTaiizor.Controls
{
    #region CrownNumeric

    public class CrownNumeric : NumericUpDown
    {
        #region Properties

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color ForeColor { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor { get; set; }

        private bool _mouseDown;

        #endregion

        #region Construct

        public CrownNumeric()
        {
            SetStyle
            (
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint,
                    true
            );

            base.ForeColor = Color.Gainsboro;
            base.BackColor = CrownColors.LightBackground;

            Controls[0].Paint += CrownNumericUpDown_Paint;

            try
            {
                // Prevent flickering, only if our assembly has reflection permission
                Type type = Controls[0].GetType();
                BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
                MethodInfo method = type.GetMethod("SetStyle", flags);

                if (method != null)
                {
                    object[] param = { ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true };
                    method.Invoke(Controls[0], param);
                }
            }
            catch (SecurityException)
            {
                // Don't do anything, we are running in a trusted contex
            }
        }

        #endregion

        #region Event

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _mouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            _mouseDown = false;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            Invalidate();
        }

        protected override void OnTextBoxLostFocus(object source, EventArgs e)
        {
            base.OnTextBoxLostFocus(source, e);
            Invalidate();
        }

        private void CrownNumericUpDown_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.ClipRectangle;

            Color fillColor = CrownColors.HeaderBackground;

            using (SolidBrush b = new SolidBrush(fillColor))
            {
                g.FillRectangle(b, rect);
            }

            Point mousePos = Controls[0].PointToClient(Cursor.Position);

            Rectangle upArea = new Rectangle(0, 0, rect.Width, rect.Height / 2);
            bool upHot = upArea.Contains(mousePos);

            Bitmap upIcon = upHot ? Properties.Resources.scrollbar_arrow_small_hot : Properties.Resources.scrollbar_arrow_small_standard;
            if (upHot && _mouseDown)
            {
                upIcon = Properties.Resources.scrollbar_arrow_small_clicked;
            }

            upIcon.RotateFlip(RotateFlipType.RotateNoneFlipY);
            g.DrawImageUnscaled(upIcon, (upArea.Width / 2) - (upIcon.Width / 2), (upArea.Height / 2) - (upIcon.Height / 2));

            Rectangle downArea = new Rectangle(0, rect.Height / 2, rect.Width, rect.Height / 2);
            bool downHot = downArea.Contains(mousePos);

            Bitmap downIcon = downHot ? Properties.Resources.scrollbar_arrow_small_hot : Properties.Resources.scrollbar_arrow_small_standard;
            if (downHot && _mouseDown)
            {
                downIcon = Properties.Resources.scrollbar_arrow_small_clicked;
            }

            g.DrawImageUnscaled(downIcon, (downArea.Width / 2) - (downIcon.Width / 2), downArea.Top + (downArea.Height / 2) - (downIcon.Height / 2));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);

            Color borderColor = CrownColors.GreySelection;

            if (Focused && TabStop)
            {
                borderColor = CrownColors.BlueHighlight;
            }

            using (Pen p = new Pen(borderColor, 1))
            {
                Rectangle modRect = new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);
                g.DrawRectangle(p, modRect);
            }
        }

        #endregion
    }

    #endregion
}