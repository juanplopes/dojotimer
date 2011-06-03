using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using DojoTimer.Resources;

namespace DojoTimer.Helpers
{
    public class ColorScheme
    {
        public static ColorScheme Green = new ColorScheme(Color.Green, Color.White, Color.DarkGreen, Icons.Green);
        public static ColorScheme Red = new ColorScheme(Color.Red, Color.White, Color.DarkRed, Icons.Red);

        Color color;
        Color darkColor;
        Color foreColor;
        Icon icon;
        public ColorScheme(Color color, Color foreColor, Color darkColor, Icon icon)
        {
            this.color = color;
            this.foreColor = foreColor;
            this.darkColor = darkColor;
            this.icon = icon;
        }

        public void ApplyTo<T>(Control control, Action<T> action)
            where T : Control
        {
            if (control is T)
                action((T)control);
        }


        public Form ApplyToMain(Form form)
        {
            form.BackColor = color;
            form.Icon = icon;

            foreach (Control control in form.Controls)
            {
                ApplyTo<ButtonBase>(control, ApplyToMain);
                ApplyTo<MainTitleBar>(control, ApplyToMain);
            }
            return form;
        }

        public void ApplyToMain(ButtonBase button)
        {
            button.FlatAppearance.BorderColor = color;
            button.FlatAppearance.CheckedBackColor = Color.FromArgb(125, Color.White);
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, Color.White);
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, Color.White);
        }

        public void ApplyToMain(MainTitleBar control)
        {
            control.BackColor = darkColor;
            control.ForeColor = foreColor;
        }

        public Form ApplyTo(Form form)
        {
            form.BackColor = Color.White;
            foreach (Control control in form.Controls)
            {
                ApplyTo<FormTitleBar>(control, ApplyTo);
                ApplyTo<ButtonBase>(control, ApplyTo);
            }
            return form;
        }


        public void ApplyTo(FormTitleBar control)
        {
            control.ForeColor = foreColor;
            control.BackColor = color;
        }

        public void ApplyTo(ButtonBase control)
        {
            control.BackColor = Color.White;
            control.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, color);
            control.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, color);
        }
    }
}
