<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="FONCTIONS_UTILISEES"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2lignes="" F2etat="inactif" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" epaisseurPoint="2" totalBoucles="5000000" epaisseurLigne="2" arrondiAuto="vrai" nbDecimales="8" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="habitant EST_DU_TYPE NOMBRE" code="1#NOMBRE#habitant"/>
        <item algoitem="nbAnnee EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbAnnee"/>
        <item algoitem="taux EST_DU_TYPE NOMBRE" code="1#NOMBRE#taux"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="habitant PREND_LA_VALEUR 96809" code="5#habitant#96809#pasliste"/>
        <item algoitem="nbAnnee PREND_LA_VALEUR 0" code="5#nbAnnee#0#pasliste"/>
        <item algoitem="taux PREND_LA_VALEUR 0.89/100" code="5#taux#0.89/100#pasliste"/>
        <item algoitem="TANT_QUE (habitant&lt;120000) FAIRE" code="15#habitant&lt;120000">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="habitant PREND_LA_VALEUR habitant+habitant*taux" code="5#habitant#habitant+habitant*taux#pasliste"/>
            <item algoitem="nbAnnee PREND_LA_VALEUR nbAnnee+1" code="5#nbAnnee#nbAnnee+1#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="AFFICHER &quot;il faudra &quot;" code="4#il faudra #0"/>
        <item algoitem="AFFICHER nbAnnee" code="3#nbAnnee#0#pasliste"/>
        <item algoitem="AFFICHER &quot;an(s)  pour atteindre &quot;" code="4#an(s)  pour atteindre #0"/>
        <item algoitem="AFFICHER habitant" code="3#habitant#0#pasliste"/>
        <item algoitem="AFFICHER &quot; Habitants&quot;" code="4# Habitants#0"/>
        <item algoitem="" code="103#commentaire"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
