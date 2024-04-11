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
	internal class GuiUtils
	{
		public static int GO_LEFT_NUM_FRAME = 4;
		public static int GO_RIGHT_NUM_FRAME = 4;
		public static int CATCH_NUM_FRAME = 4;
		public static int WAIT_NUM_FRAME = 4;

		public static int CAT_WIDTH;
		public static int CAT_HEIGHT;

		public static int MOUSE_WIDTH;
		public static int MOUSE_HEIGHT;

		public static int NODE_TRAIN_SIZEX, NODE_TRAIN_SIZEY;
		public static int NODE_BUS_SIZEX, NODE_BUS_SIZEY;
		public static int NODE_WALK_SIZEX, NODE_WALK_SIZEY;

		public static Image LOGO = Image.FromFile(Application.StartupPath + "\\Assets\\menuInterface.png");
		public static Image[] TOM_GO_LEFT_SPRITE = getSprite("Tom", "go_left", GO_LEFT_NUM_FRAME);
		public static Image[] TOM_GO_RIGHT_SPRITE = getSprite("Tom", "go_right", GO_RIGHT_NUM_FRAME);
		public static Image[] TOM_CATCH = getSprite("Tom", "go_left", CATCH_NUM_FRAME);
		public static Image[] TOM_WAIT = getSprite("Tom", "go_right", WAIT_NUM_FRAME);

		public static Image[] BUTCH_GO_LEFT_SPRITE = getSprite("Tom", "go_left", GO_LEFT_NUM_FRAME);
		public static Image[] BUTCH_GO_RIGHT_SPRITE = getSprite("Tom", "go_right", GO_RIGHT_NUM_FRAME);
		public static Image[] BUTCH_CATCH = getSprite("Tom", "go_left", CATCH_NUM_FRAME);
		public static Image[] BUTCH_WAIT = getSprite("Tom", "go_right", WAIT_NUM_FRAME);

		public static Image[] JONES_GO_LEFT_SPRITE = getSprite("Tom", "go_left", GO_LEFT_NUM_FRAME);
		public static Image[] JONES_GO_RIGHT_SPRITE = getSprite("Tom", "go_right", GO_RIGHT_NUM_FRAME);
		public static Image[] JONES_CATCH = getSprite("Tom", "go_left", CATCH_NUM_FRAME);
		public static Image[] JONES_WAIT = getSprite("Tom", "go_right", WAIT_NUM_FRAME);

		public static Image[] JERRY_GO_LEFT_SPRITE = getSprite("Tom", "go_left", GO_LEFT_NUM_FRAME);
		public static Image[] JERRY_GO_RIGHT_SPRITE = getSprite("Tom", "go_right", GO_RIGHT_NUM_FRAME);

		public static Image NODE_TRAIN = LOGO;
		public static Image NODE_BUS = LOGO;
		public static Image NODE_WALK = LOGO;

		public static SoundPlayer SOUND_CAT_WALK = getSoundPlayer("bruh.wav");
		public static SoundPlayer SOUND_CAT_CATCH = getSoundPlayer("bruh.wav");
		public static String BGM = "Not A Hero.wav";

        private static Image[] getSprite(string nameCharacter ,string nameAction, int numFrame)
		{
			Image[] sprite;
			sprite = new Image[numFrame];

			for(int index = 0; index < numFrame; index++)
			{
				string path = Application.StartupPath + "\\Assets\\" + nameCharacter + "\\" + nameAction + index + ".png";
				//DialogResult dialogResult = MessageBox.Show(path, "", MessageBoxButtons.YesNo);
				sprite[index] = Image.FromFile(path);
			}

			return sprite;
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
