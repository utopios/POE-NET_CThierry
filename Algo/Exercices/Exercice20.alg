<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="nbre PREND_LA_VALEUR 10"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2defaut="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param arrondiAuto="vrai" nbDecimales="8" totalAffichages="1000" epaisseurLigne="2" maxBoucle="500000" totalBoucles="5000000" epaisseurPoint="2"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="tabNombre EST_DU_TYPE LISTE" code="1#LISTE#tabNombre"/>
        <item algoitem="nbre EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbre"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="nbre PREND_LA_VALEUR 10" code="5#nbre#10#pasliste"/>
        <item algoitem="POUR i ALLANT_DE 1 A nbre" code="12#i#1#nbre">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="LIRE tabNombre[i]" code="2#tabNombre#i"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
        <item algoitem="POUR i ALLANT_DE 1 A nbre" code="12#i#1#nbre">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="AFFICHER tabNombre[i]" code="3#tabNombre#1#i"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
