<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER &quot;Veuillez saisir un nombre entre 1 et 3&quot;" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2para="" F2etat="inactif" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurPoint="2" epaisseurLigne="2" maxBoucle="500000" arrondiAuto="vrai" totalAffichages="1000" totalBoucles="5000000" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="nbUtil EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbUtil"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez saisir un nombre entre 1 et 3&quot;" code="4#Veuillez saisir un nombre entre 1 et 3#0"/>
        <item algoitem="LIRE nbUtil" code="2#nbUtil#pasliste"/>
        <item algoitem="TANT_QUE (nbUtil !=1 ET nbUtil !=2 ET nbUtil !=3) FAIRE" code="15#nbUtil !=1 ET nbUtil !=2 ET nbUtil !=3">
            <item algoitem="DEBUT_TANT_QUE" code="16#debuttantque"/>
            <item algoitem="AFFICHER &quot;ERREUR! Veuille saisir un chiffre entre 1 et 3&quot;" code="4#ERREUR! Veuille saisir un chiffre entre 1 et 3#0"/>
            <item algoitem="LIRE nbUtil" code="2#nbUtil#pasliste"/>
            <item algoitem="FIN_TANT_QUE" code="17#fintantque"/>
        </item>
        <item algoitem="AFFICHER &quot;Bravo vous avez saisi &quot;" code="4#Bravo vous avez saisi #0"/>
        <item algoitem="AFFICHER nbUtil" code="3#nbUtil#0#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
