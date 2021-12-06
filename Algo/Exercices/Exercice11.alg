<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER &quot; an(s) pour doubler le capital initial&quot;"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2etat="inactif" F2para="" F2lignes=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param maxBoucle="500000" totalBoucles="5000000" epaisseurPoint="2" arrondiAuto="vrai" totalAffichages="1000" nbDecimales="8" epaisseurLigne="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#Ci" algoitem="Ci EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Cf" algoitem="Cf EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Duree" algoitem="Duree EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Taux" algoitem="Taux EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuillez sasir le capital de départ#0" algoitem="AFFICHER &quot;Veuillez sasir le capital de départ&quot;"/>
        <item code="2#Ci#pasliste" algoitem="LIRE Ci"/>
        <item code="4#Veuillez saisir le taux (en %)#0" algoitem="AFFICHER &quot;Veuillez saisir le taux (en %)&quot;"/>
        <item code="2#Taux#pasliste" algoitem="LIRE Taux"/>
        <item code="5#Taux#Taux/100#pasliste" algoitem="Taux PREND_LA_VALEUR Taux/100"/>
        <item code="15#Cf&lt;2*Ci" algoitem="TANT_QUE (Cf&lt;2*Ci) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="5#Duree#Duree+1#pasliste" algoitem="Duree PREND_LA_VALEUR Duree+1"/>
            <item code="5#Cf#Ci*pow(1+Taux,Duree)#pasliste" algoitem="Cf PREND_LA_VALEUR Ci*pow(1+Taux,Duree)"/>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
        <item code="4#Il faudra #0" algoitem="AFFICHER &quot;Il faudra &quot;"/>
        <item code="3#Duree#0#pasliste" algoitem="AFFICHER Duree"/>
        <item code="4# an(s) pour doubler le capital initial#0" algoitem="AFFICHER &quot; an(s) pour doubler le capital initial&quot;"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
