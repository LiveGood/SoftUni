
import com.itextpdf.text.*;
import com.itextpdf.text.pdf.*;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class P09CardsInPdf {

	public static void main(String[] args) throws DocumentException, IOException {
		
		Document document = new Document();
        PdfWriter.getInstance(document, new FileOutputStream("MyPDF2.pdf"));   
        document.addSubject("This is result from my first PDF document");
        document.addCreationDate();
        document.addProducer();
        document.open();
        
        PdfPTable table = new PdfPTable(4);
        table.setWidthPercentage(100);
        table.getDefaultCell().setFixedHeight(180);
        
        BaseFont baseFont = BaseFont.createFont("times.ttf", BaseFont.IDENTITY_H, true);
        Font black = new Font(baseFont, 82f, 0, BaseColor.BLACK);
        Font red = new Font(baseFont, 82f, 0, BaseColor.RED);
		
        Font color = null;
		String [] cardStrings = new String [] {
				"2", "3", "4", "5",
				"6", "7", "8", "9",
				"10", "J", "Q", "K", "A" };
		String [] cardSuitStrings = new String [] { "♠", "♥", "♣", "♦" };
		String [] painting = new String [] { "black", "red", "black", "red" };
			for (int h = 0; h < cardStrings.length; h++) {
				for (int k = 0; k < cardSuitStrings.length; k++) {
					if (painting[k] == "red") {
						   color = red;
						} else {
						   color = black;
						}
					table.addCell(new Paragraph(cardStrings[h] + cardSuitStrings[k] , color));
					System.out.println(cardStrings[h] + cardSuitStrings[k]);
				}
						System.out.println();
			}
			document.add(table);
			document.close();
	}

}
