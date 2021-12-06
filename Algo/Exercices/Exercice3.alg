<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="A PREND_LA_VALEUR Tmp" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" maxBoucle="500000" totalBoucles="5000000" epaisseurLigne="2" nbDecimales="8" totalAffichages="1000" epaisseurPoint="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#A" algoitem="A EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#B" algoitem="B EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Tmp" algoitem="Tmp EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#A#1#pasliste" algoitem="A PREND_LA_VALEUR 1"/>
        <item code="5#B#2#pasliste" algoitem="B PREND_LA_VALEUR 2"/>
        <item code="5#Tmp#B#pasliste" algoitem="Tmp PREND_LA_VALEUR B"/>
        <item code="5#B#A#pasliste" algoitem="B PREND_LA_VALEUR A"/>
        <item code="5#A#Tmp#pasliste" algoitem="A PREND_LA_VALEUR Tmp"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
