using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberman {
    class Wall {
        
        private PictureBox image;
        static List<Wall> wallList = new List<Wall>();

        public Wall(int x, int y) {
            image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(image)).BeginInit();

            image.Size = new System.Drawing.Size(40, 40);
            image.Location = new System.Drawing.Point(x, y);
            image.TabIndex = 0;
            image.TabStop = false;
            image.Image = global::Bomberman.Properties.Resources.rock;

            wallList.Add(this);

            ((System.ComponentModel.ISupportInitialize)(image)).EndInit();
        }

        public PictureBox getImage() {
            return this.image;
        }

        public static void generateWalls(Control.ControlCollection controls) {
            for (int i = 0; i < 1240; i += 40) {
                Wall wall = new Wall(i, 0);
                controls.Add(wall.getImage());

                wall = new Wall(i, 640);
                controls.Add(wall.getImage());
            }

            for (int i = 40; i < 640; i += 40) {
                Wall wall = new Wall(0, i);
                controls.Add(wall.getImage());

                wall = new Wall(1200, i);
                controls.Add(wall.getImage());
            }

            for (int i = 80; i < 1200; i += 80) {
                for (int j = 80; j < 640; j += 80) {
                    Wall wall = new Wall(i, j);
                    controls.Add(wall.getImage());
                }
            }
        }
    }
}
