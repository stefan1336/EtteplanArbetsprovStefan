// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System;
// använd using System.XML för att inte behöva kvalificera klassdeklarationerna.
using System.Xml;

public class Etteplan
{
    public static void Main()
    {
        // Hämta dokumentet
        XmlDocument doc = new XmlDocument();
        doc.Load("C:\\Users\\stefa\\OneDrive\\Skrivbord\\sma_gentext.xml");

        // Välj alla transunit med matchande ID från bodyn
        XmlNodeList nodeList;
        nodeList = doc.SelectNodes("root/file/body/trans-unit[@id='42007']");

        // loopar över bodyn som matchar sökningen
        foreach(XmlNode body in nodeList)
        {
            // Kolla om FirstChild matchar 
            if(body.FirstChild == body.FirstChild)
            {
                // Skriv ut innehållet för att kontrollera
                Console.WriteLine(body.LastChild.InnerXml);
                // Skriv ut innehållet jag vill ha till en fil och lägg det på skrivbordet med nya namnet Etteplan
                File.WriteAllText("C:\\Users\\stefa\\OneDrive\\Skrivbord\\Etteplan.xml", body.LastChild.InnerText);
            }
        }
    }

}

// Din uppgift blir att hämta värdet i elementet target när attributet id är 42007 och skriva det till en fil. 
// Du får lösa det hur du vill med vilka språk/metoder/verktyg som helst men vi vill att det ska vara din egen lösning.
// Vi vill inte se någon AI-genererad lösning. Skicka sedan lösningen till oss så återkommer vi, lycka till! 😊

//<? xml version="1.0" encoding="UTF-8" ?>
//<root version="1.2">

//    <file source-language="en" target-language="sv-se" >

//        <body>

//            <group resname="_ptcsma.acl" restype="file"/>

//            <trans-unit id="42006" restype="string">

//                <source>WARNING</source>

//                <target>VARNING</target>

//            </trans-unit>

//            <trans-unit id="42007" restype="string">

//                <source>Note</source>

//                <target>Obs!</target>

//            </trans-unit>

//            <trans-unit id="42008" restype="string">

//                <source>DANGER</source>

//                <target>FARA</target>

//            </trans-unit>

//            <trans-unit id="42009" restype="string">

//                <source>CAUTION</source>

//                <target>FÖRSIKTIGHET</target>

//            </trans-unit>

//        </body>

//    </file>
//</root>