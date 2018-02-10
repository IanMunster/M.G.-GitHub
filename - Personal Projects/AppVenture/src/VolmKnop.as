package src {
	
	import flash.display.Sprite;
	import flash.events.TouchEvent;
	import flash.media.SoundMixer;
	import flash.media.SoundTransform;
		
	/**
	 * ...
	 * @author Ian Munster
	 */
	
	public class VolmKnop extends Sprite {

		private var vol:Number = 1;
		private var _channels:Array;
		private var BtnV:Sprite = new Sprite();
		
		public function VolmKnop(channels:Array){
			// constructor code
			_channels = channels;
			
			BtnV.graphics.beginFill(0x00ff00);
			BtnV.graphics.lineStyle(5, 0x000000);
			BtnV.graphics.moveTo(50,0);
			BtnV.graphics.lineTo(0, 100);
			BtnV.graphics.lineTo(100, 100);
			BtnV.graphics.lineTo(50, 0);
			BtnV.graphics.endFill();
			addChild(BtnV)
		}
	}
	
}
