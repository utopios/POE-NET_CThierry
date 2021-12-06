<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER cf"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2defaut="" F2para="" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalBoucles="5000000" totalAffichages="1000" maxBoucle="500000" arrondiAuto="vrai" nbDecimales="8" epaisseurLigne="2" epaisseurPoint="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#ci" algoitem="ci EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#t" algoitem="t EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#d" algoitem="d EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#cf" algoitem="cf EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#interets" algoitem="interets EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#Veuilez saisir le capital initial#0" algoitem="AFFICHER &quot;Veuilez saisir le capital initial&quot;"/>
        <item code="2#ci#pasliste" algoitem="LIRE ci"/>
        <item code="4#Veuillez saisir le taux#0" algoitem="AFFICHER &quot;Veuillez saisir le taux&quot;"/>
        <item code="2#t#pasliste" algoitem="LIRE t"/>
        <item code="5#t#t/100#pasliste" algoitem="t PREND_LA_VALEUR t/100"/>
        <item code="4#Veuillez saisir la durée de l'épargne#0" algoitem="AFFICHER &quot;Veuillez saisir la durée de l'épargne&quot;"/>
        <item code="2#d#pasliste" algoitem="LIRE d"/>
        <item code="5#cf#ci*pow(1+t,d)#pasliste" algoitem="cf PREND_LA_VALEUR ci*pow(1+t,d)"/>
        <item code="4#Le Capital final s'eleve à #0" algoitem="AFFICHER &quot;Le Capital final s'eleve à &quot;"/>
        <item code="3#cf#1#pasliste" algoitem="AFFICHER cf"/>
        <item code="5#interets#cf-ci#pasliste" algoitem="interets PREND_LA_VALEUR cf-ci"/>
        <item code="4#Le montant des intrets s'eleve à #0" algoitem="AFFICHER &quot;Le montant des intrets s'eleve à &quot;"/>
        <item code="3#interets#0#pasliste" algoitem="AFFICHER interets"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
