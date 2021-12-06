<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot;Votre nom complet est : &quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2defaut="" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param arrondiAuto="vrai" maxBoucle="500000" epaisseurPoint="2" epaisseurLigne="2" totalBoucles="5000000" totalAffichages="1000" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nom EST_DU_TYPE CHAINE" code="1#CHAINE#nom"/>
        <item algoitem="prenom EST_DU_TYPE CHAINE" code="1#CHAINE#prenom"/>
        <item algoitem="nom_complet EST_DU_TYPE CHAINE" code="1#CHAINE#nom_complet"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuiller saisir votre nom : &quot;" code="4#Veuiller saisir votre nom : #0"/>
        <item algoitem="LIRE nom" code="2#nom#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir votre prénom : &quot;" code="4#Veuillez saisir votre prénom : #0"/>
        <item algoitem="LIRE prenom" code="2#prenom#pasliste"/>
        <item algoitem="nom_complet PREND_LA_VALEUR nom + &quot; &quot; + prenom" code="5#nom_complet#nom + &quot; &quot; + prenom#pasliste"/>
        <item algoitem="AFFICHER &quot;Votre nom complet est : &quot;" code="4#Votre nom complet est : #0"/>
        <item algoitem="AFFICHER nom_complet" code="3#nom_complet#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
