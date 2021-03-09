using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kransteuerung
{
    public partial class Kransteuerung : Form
    {
        private bool _craneLeft;

        public Kransteuerung()
        {
            InitializeComponent();
            _craneLeft = true;
        }

        private void Haken_aus_Click(object sender, EventArgs e)
        {
            if (Haken.Location.Y + Haken.Size.Height < Floor.Location.Y)
            {
                Haken.Size = new Size(Haken.Width, Haken.Height + 10);
            }
        }

        private void Haken_ein_Click(object sender, EventArgs e)
        {
            Haken.Size = new Size(Haken.Width, Haken.Height - 10);
        }

        private void Ausleger_aus_Click(object sender, EventArgs e)
        {
            if (_craneLeft == true)
            {
                if (Arm.Location.X > 15)
                {
                    Arm.Location = new Point(Arm.Location.X - 10, Arm.Location.Y);
                    Arm.Size = new Size(Arm.Width + 10, Arm.Height);
                    Haken.Location = new Point(Haken.Location.X - 10, Haken.Location.Y);
                }
            }
            else
            {
                if (Arm.Location.X + Arm.Width < 690)
                {
                    Arm.Size = new Size(Arm.Width + 10, Arm.Height);
                    Haken.Location = new Point(Haken.Location.X + 10, Haken.Location.Y);
                }
            }
        }

        private void Ausleger_ein_Click(object sender, EventArgs e)
        {
            if (_craneLeft == true)
            {
                if (Arm.Location.X < 350)
                {
                    Arm.Location = new Point(Arm.Location.X + 10, Arm.Location.Y);
                    Arm.Size = new Size(Arm.Width - 10, Arm.Height);
                    Haken.Location = new Point(Haken.Location.X + 10, Haken.Location.Y);
                }
            }
            else
            {
                if (Arm.Location.X > 360)
                {
                    Arm.Size = new Size(Arm.Width - 10, Arm.Height);
                    Haken.Location = new Point(Haken.Location.X - 10, Haken.Location.Y);
                }
            }
        }

        private void Kran_aus_Click(object sender, EventArgs e)
        {
            if (Base.Location.Y > 15)
            {
                Base.Location = new Point(Base.Location.X, Base.Location.Y - 10);
                Base.Size = new Size(Base.Width, Base.Height + 10);
                Arm.Location = new Point(Arm.Location.X, Arm.Location.Y - 10);
                Haken.Location = new Point(Haken.Location.X, Haken.Location.Y - 10);
            }
        }

        private void Kran_ein_Click(object sender, EventArgs e)
        {
            if (Base.Location.Y < 350)
            {
                Base.Location = new Point(Base.Location.X, Base.Location.Y + 10);
                Base.Size = new Size(Base.Width, Base.Height - 10);
                Arm.Location = new Point(Arm.Location.X, Arm.Location.Y + 10);
                Haken.Location = new Point(Haken.Location.X, Haken.Location.Y + 10);
                if (Haken.Location.Y + Haken.Size.Height > Floor.Location.Y)
                {
                    Haken.Size = new Size(Haken.Width, Haken.Height - 10);
                }
            }
        }

        private void Kran_rechts_Click(object sender, EventArgs e)
        {
            if (_craneLeft == true)
            {
                _craneLeft = false;
                Arm.Location = new Point(Arm.Location.X + Arm.Width + 20, Arm.Location.Y);
                Haken.Location = new Point(Haken.Location.X + 2 * Arm.Width + 10, Haken.Location.Y);
            }
        }

        private void Kran_links_Click(object sender, EventArgs e)
        {
            if (_craneLeft == false)
            {
                _craneLeft = true;
                Arm.Location = new Point(Arm.Location.X - Arm.Width - 20, Arm.Location.Y);
                Haken.Location = new Point(Haken.Location.X - 2 * Arm.Width - 10, Haken.Location.Y);
            }
        }
    }
}
