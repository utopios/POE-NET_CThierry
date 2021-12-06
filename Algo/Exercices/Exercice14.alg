<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="Somme PREND_LA_VALEUR 0"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2lignes="" F2etat="inactif" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" epaisseurPoint="2" totalBoucles="5000000" epaisseurLigne="2" arrondiAuto="vrai" nbDecimales="8" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nbUtil EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbUtil"/>
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="Somme EST_DU_TYPE NOMBRE" code="1#NOMBRE#Somme"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez indiquer un nombre&quot;" code="4#Veuillez indiquer un nombre#0"/>
        <item algoitem="LIRE nbUtil" code="2#nbUtil#pasliste"/>
        <item algoitem="Somme PREND_LA_VALEUR 0" code="5#Somme#0#pasliste"/>
        <item algoitem="POUR i ALLANT_DE 1 A nbUtil" code="12#i#1#nbUtil">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="Somme PREND_LA_VALEUR Somme+i" code="5#Somme#Somme+i#pasliste"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
        <item algoitem="AFFICHER &quot;La somme des entiers de 1 à &quot;" code="4#La somme des entiers de 1 à #0"/>
        <item algoitem="AFFICHER nbUtil" code="3#nbUtil#0#pasliste"/>
        <item algoitem="AFFICHER &quot; est de &quot;" code="4# est de #0"/>
        <item algoitem="AFFICHER Somme" code="3#Somme#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
