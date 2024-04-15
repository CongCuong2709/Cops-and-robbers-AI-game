using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CopAndRobber
{
	public class GuiUtils
	{
		public static int GO_LEFT_NUM_FRAME = 4;
		public static int GO_RIGHT_NUM_FRAME = 4; 
		public static int CATCH_NUM_FRAME = 2;
		public static int WAIT_NUM_FRAME = 4;

        public static int CAT_WIDTH;
        public static int CAT_HEIGHT;

        public static int MOUSE_WIDTH;
        public static int MOUSE_HEIGHT;

        public static int NODE_TRAIN_SIZEX = 30, NODE_TRAIN_SIZEY = 30;
        public static int NODE_BUS_SIZEX = 30, NODE_BUS_SIZEY = 30;
        public static int NODE_WALK_SIZEX = 30, NODE_WALK_SIZEY = 30;

        public static Image LOGO = Image.FromFile(Application.StartupPath + "\\Assets\\menuInterface.png");



        public static Image NODE_TRAIN = LOGO;
        public static Image NODE_BUS = LOGO;
        public static Image NODE_WALK = LOGO;

        public static SoundPlayer SOUND_CAT_WALK = getSoundPlayer("running.wav");
        public static SoundPlayer SOUND_CAT_CATCH = getSoundPlayer("running.wav");
        public static String  BGM = "theme.wav";

        


        public static Image[] getSprite(CHARACTER_NAME name, STATE_CHARACTER state, int numFrame)
        {
            Image[] sprite;
            sprite = new Image[numFrame];
            string path;
            for (int index = 0; index < numFrame; index++)
            {
                path = Application.StartupPath + "\\Assets\\" + name.ToString() + "\\" + state.ToString() + index + ".png";
                //DialogResult dialogResult = MessageBox.Show(path, "", MessageBoxButtons.YesNo);
                sprite[index] = Image.FromFile(path);

            }

            return sprite;
        }

        public static int getNumFrame(CHARACTER_NAME name, STATE_CHARACTER state)
        {
            if (name != CHARACTER_NAME.JERRY)
            {
                if (state != STATE_CHARACTER.CATCH)
                {
                    return 4;
                }
                else
                    return 2;
            }
            else
            {
                return 4;
            }
        }

		public static Image getIcon(Character character)
		{
			Image image;
			CHARACTER_NAME name = character.getCharacterName();
			try
			{
				string path = Application.StartupPath + "\\Assets\\" + name.ToString() + ".png";
				image = Image.FromFile(path);
			}
			catch (Exception e)
			{
				image = null;
			}

			return image;
		}

		private static SoundPlayer getSoundPlayer(string fileName)
		{
			SoundPlayer soundPlayer;
			string path = Application.StartupPath + "\\Assets\\" + "Sound" + "\\" +  fileName;
			soundPlayer = new SoundPlayer(path);
			return soundPlayer;
		}

        public enum STATE_CHARACTER
        {
            WAIT,
            GO_LEFT,
            GO_RIGHT,
            CATCH,
        }

        public enum CHARACTER_NAME
        {
            TOM,
            BUTCH,
            JONES,
            JERRY,
        }
    }
}
