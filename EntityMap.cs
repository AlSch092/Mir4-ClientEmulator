//By AlSch092 @ Github
﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mir4ClientEmulator
{
    public partial class EntityMap : Form   //this class is unfinished and may not work
    {
        public EntityMap()
        {
            InitializeComponent();
        }

        private void EntityMap_Load(object sender, EventArgs e)
        {
            //load initial image/map
            //todo: get current map
            pictureBox_EntityMap.BackColor = Color.Transparent;
            pictureBox_Hero.ImageLocation = "..\\Images\\Hero.PNG";
        }

        public void LoadMap(uint stageID) //not sure if zone ID is map ID or unique instance
        {
            switch (stageID)
            {
                case 100002010:
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\PeachBlossomValley.PNG";
                    break;

                case 101003010: //ginkgo valley
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\GingkoValley.PNG";
                    break;

                case 101004040: //nefariox ruins 2f
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\NefarioxRuins2F.PNG";
                    break;

                case 101003030: //bicheon twon
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\BicheonTown.PNG";
                    break;

                case 103003010: //snake pit
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\SnakePit.PNG";
                    break;

                case 103003070: //viperbeast plain
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\ViperbeastPlain.PNG";
                    break;

                case 201400001:
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\SecretPeak1F.PNG";
                    break;

                case 105002050: //Haven's way peak 1F
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\HeavensPeak1F.PNG";
                    break;

                case 103: //demon bull temple 2f FIX ID
                    pictureBox_EntityMap.ImageLocation = ".\\Images\\Maps\\DemonBullTemple2F.PNG";
                    break;
            
            };

            pictureBox_EntityMap.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public void DrawHeroIcon(int x, int y) //draw our position onto map
        {
            pictureBox_Hero.BackColor = Color.Transparent;
            pictureBox_Hero.Parent = pictureBox_EntityMap;
            pictureBox_Hero.Location = new Point(x, y);
        }
    }
}
