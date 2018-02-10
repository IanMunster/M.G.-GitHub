package src 
{
	import flash.desktop.NativeApplication;
	import flash.display.MovieClip;
	import flash.events.Event;
	import flash.display.Sprite;
	import flash.display.StageAlign;
	import flash.display.StageScaleMode;
	import flash.ui.Multitouch;
	import flash.ui.MultitouchInputMode;
	import flash.events.TouchEvent;
	
	import flash.media.SoundTransform;
	//import flash.net.SharedObject;
	
	import flash.display.Bitmap;
	import flash.display.BitmapData;
	
	/**
	 * ...
	 * @author Ian Munster
	 */
	
	public class Main extends MovieClip
	{
		private var channels:Array = [];
		private const volmChange:Number = 0.2;
		private var crrntVolm:Number = 1;
		private var plaatjes:Array = [];
		//public var sharedVol:SharedObject;
		
		public function Main() 
		{
			stage.scaleMode = StageScaleMode.NO_SCALE;
			stage.align = StageAlign.TOP_LEFT;
			stage.addEventListener(Event.DEACTIVATE, deactivate);
			
			// touch or gesture?
			Multitouch.inputMode = MultitouchInputMode.TOUCH_POINT;
			
			// Entry point
			// New to AIR? Please read *carefully* the readme.txt files!
/*TITEL GAME*/
			var txtTitel:Textveld = new Textveld();
			txtTitel.x = 6;
			txtTitel.y = 20;
			addChild(txtTitel);
/*KAT KNOP*/			
			var btn1:Knop = new Knop(0xFFFF00, channels, crrntVolm, plaatjes);
			btn1.loadSound("http://c0026106.cdn1.cloudfiles.rackspacecloud.com/ddf67da01ed84f67aacc127ca42871b5_domestic-cat-001.mp3");
			btn1.loadImg("http://managementindebouw.nl/wp-content/uploads/2014/11/communicatie-moeilijk-make-that-the-cat-wise.jpg");
			btn1.x = 25;
			btn1.y = 280;
			addChild(btn1);
/*HOND KNOP*/			
			var btn2:Knop = new Knop(0xff0000, channels, crrntVolm, plaatjes);
			btn2.loadSound("http://c0026106.cdn1.cloudfiles.rackspacecloud.com/2fbc94686ceb434a864c0691906bd144_dog.mp3");
			btn2.loadImg("http://www.pawsaminute.net/wp-content/uploads/2015/10/bad-dog-food-150x150.jpg");
			btn2.x = 305;
			btn2.y = 280;
			addChild(btn2);
/*KIKKER KNOP*/
			var btn3:Knop = new Knop(0x00ff00, channels, crrntVolm, plaatjes);
			btn3.loadSound("http://c0026106.cdn1.cloudfiles.rackspacecloud.com/452c50e621a142509128fbf67fce4c8c_frog-001.mp3");
			btn3.loadImg("http://1funny.com/wp-content/uploads/2012/07/frog-hug-150x150.jpg");
			btn3.x = 25;
			btn3.y = 440;
			addChild(btn3);
/*PAARD KNOP*/
			var btn4:Knop = new Knop(0x0000ff, channels, crrntVolm, plaatjes);
			btn4.loadSound("http://c0026106.cdn1.cloudfiles.rackspacecloud.com/052ec56730374386b5f471a8e67647c8_clydesdale.mp3");
			btn4.loadImg("http://www.roeselienraimond.com/wp-content/uploads/2015/01/MG_3601-150x150.jpg");
			btn4.x = 305;
			btn4.y = 440;
			addChild(btn4);
/*SCHAAP KNOP*/
			var btn5:Knop = new Knop(0xFF8000, channels, crrntVolm, plaatjes);
			btn5.loadSound("http://c0026106.cdn1.cloudfiles.rackspacecloud.com/9340a00ec80244d69e037a497c742e1a_lamb-001.mp3");
			btn5.loadImg("http://www.petaasia.com/wp-content/uploads/2015/11/Wool_happy_sheep_farm_004-150x150.jpg");
			btn5.x = 25;
			btn5.y = 600;
			addChild(btn5);
/*VARKEN KNOP*/
			var btn6:Knop = new Knop(0xFF00EB, channels, crrntVolm, plaatjes);
			btn6.loadSound("http://c0026106.cdn1.cloudfiles.rackspacecloud.com/10d3fb6d1e6349f49e6f0633440c4e32_pig-001.mp3");
			btn6.loadImg("http://lancashiremicropigs.co.uk/wp-content/uploads/photo13-150x150.jpg");
			btn6.x = 305;
			btn6.y = 600;
			addChild(btn6);
			
/*STOP KNOP*/
			var btnS:StopKnop = new StopKnop();
			btnS.x = 190;
			btnS.y = 280;
			addChild(btnS);

/*VOLUME KNOPPEN*/
			var vUp:VolmKnop = new VolmKnop(channels);
			vUp.x = 190;
			vUp.y = 420;
			vUp.addEventListener(TouchEvent.TOUCH_TAP, volUp);
			addChild(vUp);
			
			var vDwn:VolmKnop = new VolmKnop(channels);
			vDwn.scaleY = -1;
			vDwn.x = 190;
			vDwn.y = 660;
			vDwn.addEventListener(TouchEvent.TOUCH_TAP, volDwn);
			addChild(vDwn);
		}
		
		private function volUp(e:TouchEvent){
			//trace("volume omhoog");
			for (var u:int = 0; u < channels.length; u++){
				var tr:SoundTransform = channels[u].soundTransform;
				var vol:Number = tr.volume;
				vol += volmChange;
				if(vol > 1){
					vol = 1;
				}
				tr.volume = vol;
				channels[u].soundTransform = tr;
				crrntVolm = vol;
			}
		}
		private function volDwn(e:TouchEvent){
			//trace("volume omlaag");
			for (var d:int = 0; d < channels.length; d++){
				var tr:SoundTransform = channels[d].soundTransform;
				var vol:Number = tr.volume;
				vol -= volmChange;
				if(vol < 0){
					vol = 0;
				}
				tr.volume = vol;
				channels[d].soundTransform = tr;
				crrntVolm = vol;
			}
			
		}
		
		private function deactivate(e:Event):void 
		{
			// make sure the app behaves well (or exits) when in background
			//NativeApplication.nativeApplication.exit();
		}
		
	}
	
}