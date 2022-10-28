using System.Runtime.InteropServices; // for custom 
using NAudio.Wave;
using Lab4.Properties;
using System.Drawing;

namespace Lab4
{
    public partial class Form1 : Form
    {
        #region Basic things
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        internal static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        //For custom panel (border) (functinality to move)

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion


        //____________________________________________________________________________________________________


        //Buttons
        #region Buttons

        internal void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void custom_dialog_button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //Drawing Tool
        #region Drawing Tool
        private void pen_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (pen_radioButton.Checked)
            {
                case true:
                    Color_groupBox.Enabled = true;
                    break;
            }
            what_is_checked(sender, e);
        }

        private void brush_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (brush_radioButton.Checked)
            {
                case true:
                    Color_groupBox.Enabled = true;
                    break;
            }
            what_is_checked(sender, e);
        }

        private void myfigure_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Reset_Figure();

            Point A = new Point(300, 250);
            Point C = new Point(A.X + 150, A.Y);
            Point B = new Point((A.X+ C.X)/2, 166);

            Point H = new Point(B.X + 100, B.Y - 50);
            Point L = new Point(C.X +100, C.Y - 50);

            Point[] front_of_triangle = new Point[] { A, B, C };

            Point[] back_of_triangle = new Point[] { B, H, L, C };

            myGraphics.FillPolygon(myBrush, front_of_triangle);
            myGraphics.FillPolygon(myBrush, back_of_triangle);

            myGraphics.DrawPolygon(myPen, front_of_triangle);
            myGraphics.DrawPolygon(myPen, back_of_triangle);
            is_shape_drawn = true;
        }

        private void colors_CheckedChanged(object sender, EventArgs e)
        {
            Color myColor = new Color();

            if (black_color_radioButton.Checked)
            {
                myColor = Color.Black;
            }
            else if (blue_color_radioButton.Checked)
            {
                myColor = Color.Blue;
            }
            else if (green_color_radioButton.Checked)
            {
                myColor = Color.Green;
            }
            else if (cyan_color_radioButton.Checked)
            {
                myColor = Color.Cyan;
            }
            else if (red_color_radioButton.Checked)
            {
                myColor = Color.Red;
            }
            else if (magenta_color_radioButton.Checked)
            {
                myColor = Color.Magenta;
            }
            else if (yellow_color_radioButton.Checked)
            {
                myColor = Color.Yellow;
            }
            else if (white_color_radioButton.Checked)
            {
                myColor = Color.White;
            }


            if (!Drawing_Shape_groupBox.Enabled)
            {
                Drawing_Shape_groupBox.Enabled = true;
            }


            if (myPen == null && myBrush == null)
            {
                myPen = new Pen(myColor);
                myBrush = new SolidBrush(myColor);
            }


            if (pen_radioButton.Checked)
            {
                myPen.Color = myColor;
            }
            else if (brush_radioButton.Checked)
            {
                myBrush.Color = myColor;
            }

            Reset_Figure();
            what_is_checked(sender, e);
        }

        private void what_is_checked(object sender, EventArgs e)
        {
            if (line_radioButton.Checked)
            {
                line_radioButton_CheckedChanged(sender, e);
            }
            else if (circle_radioButton.Checked)
            {
                circle_radioButton_CheckedChanged(sender, e);
            }
            else if (square_radioButton.Checked)
            {
                square_radioButton_CheckedChanged(sender, e);
            }
            else if (myfigure_radioButton.Checked)
            {
                myfigure_radioButton_CheckedChanged(sender, e);
            }
        }
        //
        #endregion

        // '/', '()', 'square'
        #region Shapes
        //
        Graphics myGraphics;
        Pen myPen;
        SolidBrush myBrush;
        bool is_shape_drawn = false;
        static Point center_of_space = new Point(438, 157); //(438, 157) //is const
        Point common_point_for_figures = new Point(center_of_space.X - common_size_of_figures.Width / 2, 
                                                   center_of_space.Y - common_size_of_figures.Height / 2);

        static Size common_size_of_figures = new Size(150, 150);

        private void Reset_Figure() 
        {
            if (is_shape_drawn)
            {
                myGraphics.Clear(Color.FromArgb(42, 43, 48));
                myGraphics.Dispose();
                is_shape_drawn = false;
            }
            myGraphics = CreateGraphics();
        }

        //314; 138

        private void line_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Reset_Figure(); 

            Point point1 = new Point(common_point_for_figures.X, common_point_for_figures.Y + common_size_of_figures.Width);
            Point point2 = new Point(point1.X+ common_size_of_figures.Width, point1.Y- common_size_of_figures.Width);

            myGraphics.DrawLine(myPen, point1, point2);

            is_shape_drawn = true;
        }

        // ()
        private void circle_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Reset_Figure();
            Rectangle rectangle = new Rectangle(common_point_for_figures, common_size_of_figures);

            myGraphics.FillEllipse(myBrush, rectangle);
            myGraphics.DrawEllipse(myPen, rectangle);
            Pen temp_pen = myPen;

            is_shape_drawn = true;
        }

        // _______
        // |     |
        // |     |
        // -------
        private void square_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Reset_Figure();

            Rectangle rectangle = new Rectangle(common_point_for_figures, common_size_of_figures);

            myGraphics.FillRectangle(myBrush, rectangle);
            myGraphics.DrawRectangle(myPen, rectangle);

            is_shape_drawn = true;
        }
        //
        #endregion

        //Sound
        #region Sound
        Stream get_audio_path; 
        Mp3FileReader audio_to_play;
        WaveOut audio_output = new WaveOut();
        const int default_Value = 50; //50
        private void volume_trackBar_Scroll(object sender, EventArgs e)
        {
            if (audio_output.PlaybackState == PlaybackState.Stopped)
            {
                return;
            }
            audio_output.Volume = (float)volume_trackBar.Value / 100;
        }
        private void reset_volume_button_Click(object sender, EventArgs e)
        {
            volume_trackBar.Value = default_Value;
            volume_trackBar_Scroll(sender, e);
        }

        private void speed_trackBar_Scroll(object sender, EventArgs e)
        {
            //doesnt work saj
        }
        private void reset_speed_button_Click(object sender, EventArgs e)
        {
            speed_trackBar.Value = default_Value;
            speed_trackBar_Scroll(sender, e);
        }

        private void voice_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (voice_comboBox.SelectedIndex)
            {
                case 0:
                    if (audio_output != null && audio_output.PlaybackState == PlaybackState.Playing)
                    {
                        return;
                    }

                    start_voice_button.Enabled = false;
                    stop_voice_button.Enabled = false;
                    volume_trackBar.Enabled = false;
                    speed_trackBar.Enabled = false;
                    reset_volume_button.Enabled = false;
                    reset_speed_button.Enabled = false;
                    break;

                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    start_voice_button.Enabled = true;
                    volume_trackBar.Enabled = true;
                    speed_trackBar.Enabled = true;
                    reset_volume_button.Enabled = true;
                    reset_speed_button.Enabled = true;
                    break;
            }
        }

        private void start_voice_button_Click(object sender, EventArgs e)
        {
            Dispose_Audio();

            switch (voice_comboBox.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    bool_start_and_stop_buttons(true);
                    switch (voice_comboBox.SelectedIndex)
                    {
                        case 1:
                            get_audio_path = new MemoryStream(Resources.mixkit_medieval_orchestra_announcement_694);
                            break;

                        case 2:
                            get_audio_path = new MemoryStream(Resources.mixkit_mythical_violin_jingle_2281);
                            break;

                        case 3:
                            get_audio_path = new MemoryStream(Resources.mixkit_spooky_wind_metal_music_698);
                            break;

                        case 4:
                            get_audio_path = new MemoryStream(Resources.mixkit_suspense_alien_horns_714);
                            break;

                        case 5:
                            get_audio_path = new MemoryStream(Resources.Joker_Official_Soundtrack___Bathroom_Dance___Hildur_Guðnadóttir___WaterTower);
                            break;
                    }
                    Play_Audio();
                    break;
            }
        }
        private void bool_start_and_stop_buttons(bool true_or_false)
        {
            start_voice_button.Enabled = !true_or_false;
            stop_voice_button.Enabled = true_or_false;
        }
        private void Play_Audio()
        {
            audio_to_play = new Mp3FileReader(get_audio_path);
            //audio_output = new WaveOut();
            audio_output.Init(audio_to_play);
            audio_output.Play();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (audio_output == null)
            {
                return;
            }

            audio_output.Stop();

            Dispose_Audio();

            switch (voice_comboBox.SelectedIndex)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    bool_start_and_stop_buttons(false);
                    break;
            }
        }
        private void Dispose_Audio()
        {
            if (audio_output != null && get_audio_path != null && audio_output != null)
            {

                audio_output.Dispose();
                get_audio_path.Dispose();
                audio_to_play.Dispose();
/*
                audio_output = null;
                get_audio_path = null;
                audio_to_play = null;
*/
            }
        }
        #endregion
    }
}