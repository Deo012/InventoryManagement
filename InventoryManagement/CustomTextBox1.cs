using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox1 : UserControl
    {
        //Fields for controling style of textarea
        private Color borderColor = Color.Gray;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color borderFocusColor = Color.LightBlue;
        private bool isFocused = false;
        private Color borderHoverColor = Color.LightCyan;
        private bool isHovered = false;

        //Events
        public event EventHandler _TextChanged;

        //Properties
        [Category("TextBox Déo")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Déo")]
        public int BorderSize
        {
            get { return this.borderSize; }
            set
            {
                this.borderSize = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Déo")]
        public bool UnderlineStyle
        {
            get { return this.underlineStyle; }
            set
            {
                this.underlineStyle = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Déo")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; } 
        }

        [Category("TextBox Déo")]
        public bool Multiline
        {
            get { return textBox1.Multiline; ;}
            set { textBox1.Multiline = value;}
        }

        [Category("TextBox Déo")]
        public override Color BackColor 
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            } 
        }

        [Category("TextBox Déo")]
        public override Color ForeColor 
        {
            get { return base.ForeColor; } 
            set 
            { 
                base.ForeColor = value; 
                textBox1.ForeColor = value;
            }
        }

        [Category("TextBox Déo")]
        public override Font Font 
        {
            get
            {
                return base.Font;
            } 
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        [Category("TextBox Déo")]
        public string Texts
        {
            get { return base.Text; } 
            set
            {
                textBox1.Text = value;

            }
        }

        [Category("TextBox Déo")]
        public Color BorderFocusColor 
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }

        [Browsable(true)]
        [Category("TextBox Déo")]
        public Color BorderHoverColor 
        { 
            get
            {
                return this.borderHoverColor;
            }
            set
            {
                borderHoverColor = value;
            } 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            //draw border of text box
            using (Pen penBorder = new Pen(borderColor, BorderSize)) //using destroy the pen when its no longer needed
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                
                if(!isFocused && !isHovered)
                {
                    if (UnderlineStyle)//Line style
                    {
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else//Normal style
                    {
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
                else if(isFocused)
                {
                    penBorder.Color = borderFocusColor;

                    if (UnderlineStyle)//Line style
                    {
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else//Normal style
                    {
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
                else if(isHovered)
                {
                    penBorder.Color = BorderHoverColor;

                    if (UnderlineStyle)//Line style
                    {
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else//Normal style
                    {
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        //Constructor
        public CustomTextBox1()
            {
                InitializeComponent();
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            this.Invalidate();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            this.OnMouseHover(e);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.isHovered = true;
            this.Invalidate();
        }
    }
}
