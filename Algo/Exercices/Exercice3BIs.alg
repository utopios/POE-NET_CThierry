<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="ch1 PREND_LA_VALEUR &quot;Le double de &quot; + A + &quot; est &quot;+B " texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" maxBoucle="500000" totalBoucles="5000000" epaisseurLigne="2" nbDecimales="8" totalAffichages="1000" epaisseurPoint="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#A" algoitem="A EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#B" algoitem="B EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#ch1" algoitem="ch1 EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Entrez un nombre#0" algoitem="AFFICHER &quot;Entrez un nombre&quot;"/>
        <item code="2#A#pasliste" algoitem="LIRE A"/>
        <item code="5#B#2*A#pasliste" algoitem="B PREND_LA_VALEUR 2*A"/>
        <item code="4#Le double de #0" algoitem="AFFICHER &quot;Le double de &quot;"/>
        <item code="3#A#0#pasliste" algoitem="AFFICHER A"/>
        <item code="4# est #0" algoitem="AFFICHER &quot; est &quot;"/>
        <item code="3#B#1#pasliste" algoitem="AFFICHER B"/>
        <item code="5#ch1#&quot;Le double de &quot; + A + &quot; est &quot;+B #pasliste" algoitem="ch1 PREND_LA_VALEUR &quot;Le double de &quot; + A + &quot; est &quot;+B "/>
        <item code="3#ch1#0#pasliste" algoitem="AFFICHER ch1"/>
        <item code="103#commentaire" algoitem=""/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
