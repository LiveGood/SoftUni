
import java.awt.Graphics;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

import org.apache.batik.dom.GenericDOMImplementation;
import org.apache.batik.svggen.SVGGraphics2D;
import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Document;

/* BasicJPanel.java
  This is a somewhat more sophisticated drawing program.
  It uses a new child of JPanel as the drawing surface
  for a JFrame, to avoid the problems with drawing
  directly on a JFrame.

  A custom JPanel child class called BasicJPanel is created
  with its own paintComponent method, which contains our
  drawing code.
 
  A generic JFrame is then created to hold the BasicJPanel
  object, the BasicJPanel is created, made into the JPanel's
  content pane, and our paintComponent method is called
  automatically. *Whew!*
  mag-28Apr2008
*/

// Import the basic graphics classes.
public class _10PaintHouseSVG {

	  public static void main(String arg[]) throws IOException{
	
		  _10PaintHouseSVG house = new _10PaintHouseSVG();
		  DOMImplementation domImplementation = GenericDOMImplementation.getDOMImplementation();
		
		  Document doc = domImplementation.createDocument(null, "svg", null);
		  SVGGraphics2D svg = new SVGGraphics2D(doc);
		  house.paint(svg);
		  svg.stream(new FileWriter("house.html"), false);
	  }
	  
	  public void paint(Graphics g) {
		  Scanner input = new Scanner(System.in);
		  double x = input.nextDouble();
		  double y = input.nextDouble();
	  }
}