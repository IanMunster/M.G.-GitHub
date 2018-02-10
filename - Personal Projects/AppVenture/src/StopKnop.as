package src {
	
	import flash.display.Sprite;
	import flash.events.TouchEvent;
	import flash.media.SoundMixer;
		
	/**
	 * ...
	 * @author Ian Munster
	 */
	
	public class StopKnop extends Sprite {

		private var BtnS:Sprite = new Sprite();
		
		public function StopKnop(){
			// constructor code
			BtnS.graphics.beginFill(0xff0000);
			BtnS.graphics.lineStyle(5, 0x000000);
			BtnS.graphics.drawRect(0, 0, 100, 100);
			BtnS.graphics.endFill();
			BtnS.addEventListener(TouchEvent.TOUCH_TAP, aanraken);
			addChild(BtnS)
		}
		
		private function aanraken(e:TouchEvent):void {
		SoundMixer.stopAll();

		}
		
	}
	
}
