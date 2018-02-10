package src
{
	import flash.display.Sprite;
	import flash.display.MovieClip;
	import flash.ui.Multitouch;
	import flash.ui.MultitouchInputMode;
	import flash.events.TouchEvent;
	import flash.net.URLRequest;
	import flash.media.Sound;
	import flash.media.SoundTransform;
	
	import flash.display.BitmapData;
	import flash.display.Bitmap;
	import flash.display.Loader;
	import flash.display.LoaderInfo;
	import flash.events.Event;
		
	/**
	 * ...
	 * @author Ian Munster
	 */
	
	public class Knop extends Sprite {
		
		private var btn:Sprite = new Sprite();
		private var _sound:Sound;
		private var _channels:Array;
		private var _soundTrans:SoundTransform;
		private var _volmChange:Number;
		
		private var _img:BitmapData;
		private var _plaatjes:Array;
		public var hokje = new MovieClip;
		
		public function Knop(color:uint, channels:Array, volmChange:Number, plaatjes:Array) {
			// constructor code
			_channels = channels;
			_volmChange = volmChange;
			_plaatjes = plaatjes;
			
			btn.graphics.beginFill(color);
			btn.graphics.lineStyle(5, 0x000000);
			btn.graphics.drawRect(0, 0, 150, 150);
			btn.graphics.endFill();
			btn.addEventListener(TouchEvent.TOUCH_TAP, aanraken);
			hokje.addEventListener(TouchEvent.TOUCH_TAP, aanraken);
			addChild(btn);
			
			_soundTrans = new SoundTransform(volmChange,0);
		}
		
		function loadSound(url:String):void {
			var urlReq:URLRequest = new URLRequest(url);
			_sound = new Sound(urlReq);
			//trace("SoundLoaded"+this);
		}
		//IMG TOEVOEGEN
		function loadImg(url:String):void {
			
			var loader:Loader = new Loader();
			loader.load(new URLRequest(url));
			loader.contentLoaderInfo.addEventListener(Event.COMPLETE, makeImg);
			//trace("Img Loaded "+this);
			
			function makeImg(e:Event):void{
				_img = Bitmap(LoaderInfo(e.target).content).bitmapData;
				hokje.graphics.clear();
				hokje.graphics.beginBitmapFill(_img, null, false, true);
				hokje.graphics.drawRect(0,0,150,150);
				hokje.graphics.endFill();
				addChild(hokje);
				if(_img == null){
					throw new Error ("IMG couldn't load in "+ this, 2);
				}else {
					_plaatjes.push(hokje);
					//trace("show img"+this);
				}
			}
		}
		
		
		function aanraken(e:TouchEvent):void {
			if(_sound == null){
				throw new Error ("Sound couldn't load in "+ this, 1);
			} else {
				_channels.push(_sound.play(0, 1, _soundTrans));
				//trace("play sound"+this);
			}
		}

	}
	
}
