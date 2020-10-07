﻿#region Imports

using System;
using System.Drawing;
using ReaLTaiizor.Util;
using ReaLTaiizor.Colors;
using System.Windows.Forms;
using System.ComponentModel;
using ReaLTaiizor.Enum.Crown;

#endregion

namespace ReaLTaiizor.Controls
{
    #region CrownCheckBox

    public class CrownCheckBox : System.Windows.Forms.CheckBox
    {
        #region Field Region

        private ControlState _controlState = ControlState.Normal;

        private bool _spacePressed;

        #endregion

        #region Property Region

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Appearance Appearance => base.Appearance;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool AutoEllipsis => base.AutoEllipsis;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image BackgroundImage => base.BackgroundImage;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ImageLayout BackgroundImageLayout => base.BackgroundImageLayout;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool FlatAppearance => false;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new FlatStyle FlatStyle => base.FlatStyle;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Image Image => base.Image;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new System.Drawing.ContentAlignment ImageAlign => base.ImageAlign;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int ImageIndex => base.ImageIndex;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string ImageKey => base.ImageKey;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ImageList ImageList => base.ImageList;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new System.Drawing.ContentAlignment TextAlign => base.TextAlign;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new TextImageRelation TextImageRelation => base.TextImageRelation;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool ThreeState => base.ThreeState;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool UseCompatibleTextRendering => false;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool UseVisualStyleBackColor => false;

        #endregion

        #region Constructor Region

        public CrownCheckBox()
        {
            SetStyle
            (
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint,
                    true
            );
        }

        #endregion

        #region Method Region

        private void SetControlState(ControlState controlState)
        {
            if (_controlState != controlState)
            {
                _controlState = controlState;
                Invalidate();
            }
        }

        #endregion

        #region Event Handler Region

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_spacePressed)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                if (ClientRectangle.Contains(e.Location))
                {
                    SetControlState(ControlState.Pressed);
                }
                else
                {
                    SetControlState(ControlState.Hover);
                }
            }
            else
            {
                SetControlState(ControlState.Hover);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (!ClientRectangle.Contains(e.Location))
            {
                return;
            }

            SetControlState(ControlState.Pressed);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_spacePressed)
            {
                return;
            }

            SetControlState(ControlState.Normal);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (_spacePressed)
            {
                return;
            }

            SetControlState(ControlState.Normal);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);

            if (_spacePressed)
            {
                return;
            }

            Point location = Cursor.Position;

            if (!ClientRectangle.Contains(location))
            {
                SetControlState(ControlState.Normal);
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            _spacePressed = false;

            Point location = Cursor.Position;

            if (!ClientRectangle.Contains(location))
            {
                SetControlState(ControlState.Normal);
            }
            else
            {
                SetControlState(ControlState.Hover);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Space)
            {
                _spacePressed = true;
                SetControlState(ControlState.Pressed);
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.Space)
            {
                _spacePressed = false;

                Point location = Cursor.Position;

                if (!ClientRectangle.Contains(location))
                {
                    SetControlState(ControlState.Normal);
                }
                else
                {
                    SetControlState(ControlState.Hover);
                }
            }
        }

        #endregion

        #region Paint Region

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);

            int size = Consts.CheckBoxSize;

            Color textColor = CrownColors.LightText;
            Color borderColor = CrownColors.LightText;
            Color fillColor = CrownColors.LightestBackground;

            if (Enabled)
            {
                if (Focused)
                {
                    borderColor = CrownColors.BlueHighlight;
                    fillColor = CrownColors.BlueSelection;
                }

                if (_controlState == ControlState.Hover)
                {
                    borderColor = CrownColors.BlueHighlight;
                    fillColor = CrownColors.BlueSelection;
                }
                else if (_controlState == ControlState.Pressed)
                {
                    borderColor = CrownColors.GreyHighlight;
                    fillColor = CrownColors.GreySelection;
                }
            }
            else
            {
                textColor = CrownColors.DisabledText;
                borderColor = CrownColors.GreyHighlight;
                fillColor = CrownColors.GreySelection;
            }

            using (SolidBrush b = new SolidBrush(CrownColors.GreyBackground))
            {
                g.FillRectangle(b, rect);
            }

            using (Pen p = new Pen(borderColor))
            {
                Rectangle boxRect = new Rectangle(0, (rect.Height / 2) - (size / 2), size, size);
                g.DrawRectangle(p, boxRect);
            }

            if (Checked)
            {
                using (SolidBrush b = new SolidBrush(fillColor))
                {
                    Rectangle boxRect = new Rectangle(2, (rect.Height / 2) - ((size - 4) / 2), size - 3, size - 3);
                    g.FillRectangle(b, boxRect);
                }
            }

            using (SolidBrush b = new SolidBrush(textColor))
            {
                StringFormat stringFormat = new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                };

                Rectangle modRect = new Rectangle(size + 4, 0, rect.Width - size, rect.Height);
                g.DrawString(Text, Font, b, modRect, stringFormat);
            }
        }

        #endregion
    }

    #endregion
}