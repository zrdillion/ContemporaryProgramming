using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceObjects;

namespace Program5
{
    public partial class SpaceObjectForm : Form
    {
        //Creates an array of five space objects
        SpaceObject[] spaceObjects = new SpaceObject[5];
        public SpaceObjectForm()
        {
            InitializeComponent();
        }

        private void earthlingButton_CheckedChanged(object sender, EventArgs e)
        {
            earthlingBox.Enabled = true;
            earthlingBox.Visible = true;
            martianBox.Enabled = false;
            martianBox.Visible = false;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            starBox.Enabled = false;
            starBox.Visible = false;
            shipBox.Enabled = false;
            shipBox.Visible = false;
        }

        private void martianButton_CheckedChanged_1(object sender, EventArgs e)
        {
            martianBox.Enabled = true;
            martianBox.Visible = true;
            earthlingBox.Visible = false;
            earthlingBox.Enabled = false;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            starBox.Enabled = false;
            starBox.Visible = false;
            shipBox.Enabled = false;
            shipBox.Visible = false;
        }

        private void planetButton_CheckedChanged(object sender, EventArgs e)
        {
            planetBox.Enabled = true;
            planetBox.Visible = true;
            earthlingBox.Enabled = false;
            earthlingBox.Visible = false;
            martianBox.Enabled = false;
            martianBox.Visible = false;
            starBox.Enabled = false;
            starBox.Visible = false;
            shipBox.Enabled = false;
            shipBox.Visible = false;
        }

        private void starButton_CheckedChanged(object sender, EventArgs e)
        {
            starBox.Enabled = true;
            starBox.Visible = true;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            earthlingBox.Enabled = false;
            earthlingBox.Visible = false;
            martianBox.Enabled = false;
            martianBox.Visible = false;
            shipBox.Enabled = false;
            shipBox.Visible = false;
        }

        private void shipButton_CheckedChanged(object sender, EventArgs e)
        {
            shipBox.Enabled = true;
            shipBox.Visible = true;
            starBox.Enabled = false;
            starBox.Visible = false;
            planetBox.Enabled = false;
            planetBox.Visible = false;
            earthlingBox.Enabled = false;
            earthlingBox.Visible = false;
            martianBox.Enabled = false;
            martianBox.Visible = false;
        }

        private void earthlingCreateButton_Click(object sender, EventArgs e)
        {
            spaceObjects[0] = new Earthling(int.Parse(earthlingXBox.Text), int.Parse(earthlingYBox.Text),
                                            int.Parse(earthlingZBox.Text), double.Parse(earthlingHeightBox.Text),
                                            int.Parse(earthlingArmBox.Text), double.Parse(earthlingSpeedBox.Text));
            earthlingOutLabel.Text = spaceObjects[0].ToString();
            earthlingOutBox.Enabled = true;
            earthlingOutBox.Visible = true;
            martianOutBox.Enabled = false;
            martianOutBox.Visible = false;
            planetOutBox.Enabled = false;
            planetOutBox.Visible = false;
            shipOutBox.Enabled = false;
            shipOutBox.Visible = false;
        }

        private void martianCreateButton_Click(object sender, EventArgs e)
        {
            spaceObjects[1] = new Martian(int.Parse(martianXBox.Text), int.Parse(martianYBox.Text),
                                          int.Parse(martianZBox.Text), double.Parse(martianHeightBox.Text),
                                          int.Parse(martianArmBox.Text), double.Parse(martianTeleportBox.Text));
            martianOutLabel.Text = spaceObjects[1].ToString();
            martianOutBox.Enabled = true;
            martianOutBox.Visible = true;
            earthlingOutBox.Enabled = false;
            earthlingOutBox.Visible = false;
            planetOutBox.Enabled = false;
            planetOutBox.Visible = false;
            shipOutBox.Enabled = false;
            shipOutBox.Visible = false;
        }

        private void planetCreateButton_Click(object sender, EventArgs e)
        {
            spaceObjects[2] = new Planet(int.Parse(planetXBox.Text), int.Parse(planetYBox.Text),
                                          int.Parse(planetZBox.Text), double.Parse(planetRadiusBox.Text),
                                          bool.Parse(planetWaterBox.Text), int.Parse(planetMoonBox.Text), 
                                          bool.Parse(planetAtmosBox.Text));
            planetOutLabel.Text = spaceObjects[2].ToString();
            planetOutBox.Enabled = true;
            planetOutBox.Visible = true;
            martianOutBox.Enabled = false;
            martianOutBox.Visible = false;
            earthlingOutBox.Enabled = false;
            earthlingOutBox.Visible = false;
            shipOutBox.Enabled = false;
            shipOutBox.Visible = false;
        }

        private void starCreateButton_Click(object sender, EventArgs e)
        {
            spaceObjects[3] = new Star(int.Parse(starXBox.Text), int.Parse(starYBox.Text),
                                        int.Parse(starZBox.Text),double.Parse(starRadiusBox.Text),
                                        double.Parse(starTempBox.Text), double.Parse(starLumBox.Text));
            starOutLabel.Text = spaceObjects[3].ToString();
            starOutBox.Enabled = true;
            starOutBox.Visible = true;
            planetOutBox.Enabled = false;
            planetOutBox.Visible = false;
            martianOutBox.Enabled = false;
            martianOutBox.Visible = false;
            earthlingOutBox.Enabled = false;
            earthlingOutBox.Visible = false;
            shipOutBox.Enabled = false;
            shipOutBox.Visible = false;
        }

        private void shipCreateButton_Click(object sender, EventArgs e)
        {
            spaceObjects[4] = new SpaceShip(int.Parse(shipXBox.Text), int.Parse(shipYBox.Text),
                                        int.Parse(shipZBox.Text), shipTypeBox.Text,
                                        double.Parse(shipPayloadBox.Text), double.Parse(shipFuelBox.Text),
                                        double.Parse(shipSpeedBox.Text), int.Parse(shipCrewBox.Text));
            shipOutLabel.Text = spaceObjects[4].ToString();
            shipOutBox.Enabled = true;
            shipOutBox.Visible = true;
            starOutBox.Enabled = false;
            starOutBox.Visible = false;
            planetOutBox.Enabled = false;
            planetOutBox.Visible = false;
            martianOutBox.Enabled = false;
            martianOutBox.Visible = false;
            earthlingOutBox.Enabled = false;
            earthlingOutBox.Visible = false;

        }
    }
}
