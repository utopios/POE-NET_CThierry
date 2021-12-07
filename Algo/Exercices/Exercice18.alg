<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="APPELER_FONCTION afficherResultat()" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2para="" F2defaut="" F2lignes=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" maxBoucle="500000" totalAffichages="1000" totalBoucles="5000000" nbDecimales="8" epaisseurLigne="2" arrondiAuto="vrai"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions">
        <item algoitem="FONCTION afficherResultat( )" code="201#afficherResultat# ">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction"/>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="AFFICHER &quot;La plus grande valeur est : &quot;" code="4#La plus grande valeur est : #0"/>
            <item algoitem="AFFICHER resultat" code="3#resultat#0#pasliste"/>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
        <item algoitem="FONCTION comparerNombre(nb1,nb2)" code="201#comparerNombre#nb1,nb2">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction"/>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="SI (nb1 > nb2) ALORS" code="6#nb1 > nb2">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="RENVOYER nb1" code="205#nb1"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
                <item algoitem="SINON" code="9#sinon">
                    <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                    <item algoitem="RENVOYER nb2" code="205#nb2"/>
                    <item algoitem="FIN_SINON" code="11#finsinon"/>
                </item>
            </item>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
    </item>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nombre1 EST_DU_TYPE NOMBRE" code="1#NOMBRE#nombre1"/>
        <item algoitem="nombre2 EST_DU_TYPE NOMBRE" code="1#NOMBRE#nombre2"/>
        <item algoitem="resultat EST_DU_TYPE NOMBRE" code="1#NOMBRE#resultat"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir un nombre 1 : &quot;" code="4#Veuillez saisir un nombre 1 : #0"/>
        <item algoitem="LIRE nombre1" code="2#nombre1#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le nombre 2&quot;" code="4#Veuillez saisir le nombre 2#0"/>
        <item algoitem="LIRE nombre2" code="2#nombre2#pasliste"/>
        <item algoitem="resultat PREND_LA_VALEUR comparerNombre(nombre1,nombre2)" code="5#resultat#comparerNombre(nombre1,nombre2)#pasliste"/>
        <item algoitem="APPELER_FONCTION afficherResultat()" code="206#afficherResultat()"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir un nombre 1 : &quot;" code="4#Veuillez saisir un nombre 1 : #0"/>
        <item algoitem="LIRE nombre1" code="2#nombre1#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le nombre 2&quot;" code="4#Veuillez saisir le nombre 2#0"/>
        <item algoitem="LIRE nombre2" code="2#nombre2#pasliste"/>
        <item algoitem="resultat PREND_LA_VALEUR comparerNombre(nombre1,nombre2)" code="5#resultat#comparerNombre(nombre1,nombre2)#pasliste"/>
        <item algoitem="APPELER_FONCTION afficherResultat()" code="206#afficherResultat()"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
