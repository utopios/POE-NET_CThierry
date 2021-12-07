<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="APPELER_FONCTION afficherResultat(resultat,laChaine)" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2para="" F2defaut="" F2lignes=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" maxBoucle="500000" totalAffichages="1000" totalBoucles="5000000" nbDecimales="8" epaisseurLigne="2" arrondiAuto="vrai"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions">
        <item algoitem="FONCTION Max(A,B)" code="201#Max#A,B">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction"/>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="SI (A>B) ALORS" code="6#A>B">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="RENVOYER A" code="205#A"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
                <item algoitem="SINON" code="9#sinon">
                    <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                    <item algoitem="RENVOYER B" code="205#B"/>
                    <item algoitem="FIN_SINON" code="11#finsinon"/>
                </item>
            </item>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
        <item algoitem="FONCTION afficherResultat(valeur,chaine)" code="201#afficherResultat#valeur,chaine">
            <item algoitem="VARIABLES_FONCTION" code="202#declarationsvariablesfonction">
                <item algoitem="val EST_DU_TYPE NOMBRE" code="1#NOMBRE#val"/>
                <item algoitem="message EST_DU_TYPE CHAINE" code="1#CHAINE#message"/>
            </item>
            <item algoitem="DEBUT_FONCTION" code="203#debutfonction"/>
            <item algoitem="val PREND_LA_VALEUR valeur" code="5#val#valeur#pasliste"/>
            <item algoitem="message PREND_LA_VALEUR chaine" code="5#message#chaine#pasliste"/>
            <item algoitem="AFFICHER message" code="3#message#0#pasliste"/>
            <item algoitem="AFFICHER &quot; &quot;" code="4# #0"/>
            <item algoitem="AFFICHER val" code="3#val#0#pasliste"/>
            <item algoitem="FIN_FONCTION" code="204#finfonction"/>
        </item>
    </item>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nb1 EST_DU_TYPE NOMBRE" code="1#NOMBRE#nb1"/>
        <item algoitem="nb2 EST_DU_TYPE NOMBRE" code="1#NOMBRE#nb2"/>
        <item algoitem="laChaine EST_DU_TYPE CHAINE" code="1#CHAINE#laChaine"/>
        <item algoitem="resultat EST_DU_TYPE NOMBRE" code="1#NOMBRE#resultat"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir le nombre 1 : &quot;" code="4#Veuillez saisir le nombre 1 : #0"/>
        <item algoitem="LIRE nb1" code="2#nb1#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le nombre 2 : &quot;" code="4#Veuillez saisir le nombre 2 : #0"/>
        <item algoitem="LIRE nb2" code="2#nb2#pasliste"/>
        <item algoitem="AFFICHER &quot;Veuillez saisir le message : &quot;" code="4#Veuillez saisir le message : #0"/>
        <item algoitem="LIRE laChaine" code="2#laChaine#pasliste"/>
        <item algoitem="resultat PREND_LA_VALEUR Max(nb1,nb2)" code="5#resultat#Max(nb1,nb2)#pasliste"/>
        <item algoitem="APPELER_FONCTION afficherResultat(resultat,laChaine)" code="206#afficherResultat(resultat,laChaine)"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
