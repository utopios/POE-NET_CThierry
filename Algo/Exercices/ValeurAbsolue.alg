<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="SI (x&lt;0) ALORS" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2etat="inactif" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" epaisseurLigne="2" nbDecimales="8" maxBoucle="500000" epaisseurPoint="2" arrondiAuto="vrai" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="x EST_DU_TYPE NOMBRE" code="1#NOMBRE#x"/>
        <item algoitem="reponse EST_DU_TYPE CHAINE" code="1#CHAINE#reponse"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir un nombre :&quot;" code="4#Veuillez saisir un nombre :#0"/>
        <item algoitem="LIRE x" code="2#x#pasliste"/>
        <item algoitem="SI (x&lt;0) ALORS" code="6#x&lt;0">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="reponse PREND_LA_VALEUR &quot;La valeur absolue de &quot;+ x +&quot; est &quot;+(-x)" code="5#reponse#&quot;La valeur absolue de &quot;+ x +&quot; est &quot;+(-x)#pasliste"/>
            <item algoitem="AFFICHER reponse" code="3#reponse#0#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="reponse PREND_LA_VALEUR &quot;La valeur absolue de &quot;+ x +&quot; est &quot;+ x" code="5#reponse#&quot;La valeur absolue de &quot;+ x +&quot; est &quot;+ x#pasliste"/>
                <item algoitem="AFFICHER reponse" code="3#reponse#0#pasliste"/>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
