package src {

	import flash.display.Sprite;
	import flash.text.TextFormat;
	import flash.text.TextField;
	
	/**
	 * ...
	 * @author Ian Munster
	 */
	
	public class Textveld extends Sprite {

		public function Textveld() {
			// constructor code
			var tekstForm:TextFormat = new TextFormat();
			var tekstFormB:TextFormat = new TextFormat();
			var titel:TextField = new TextField();
			var titelB:TextField = new TextField();
			var titelBG:Sprite = new Sprite();
			
			tekstForm.font = "_sans";
			tekstForm.size = 60;
			tekstForm.color = 0x000000;
			tekstForm.bold = true;

			tekstFormB.font = "_sans";
			tekstFormB.size = 60;
			tekstFormB.color = 0x0000ff;
			tekstFormB.bold = true;
			
			titel.text = "Raad-je-Plaat-je";
			titel.setTextFormat(tekstFormB);
			titel.width = titel.textWidth + 15;
			titel.height = titel.textHeight + 15;
			titel.x += 3;
			titel.y += 3;

			titelB.text = "Raad-je-Plaat-je";
			titelB.setTextFormat(tekstForm);
			titelB.width = titel.textWidth + 15;
			titelB.height = titel.textHeight + 15;
			
			titelBG.graphics.beginFill(0x00ffff);
			titelBG.graphics.lineStyle(5, 0x000000);
			titelBG.graphics.drawRect(0,0, titel.width + 5, titel.height + 5)
			
			addChild(titelBG);
			addChild(titelB);
			addChild(titel);
		}

	}
	
}
