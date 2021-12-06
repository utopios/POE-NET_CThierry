<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER &quot;/20&quot;"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2lignes="" F2etat="inactif" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalAffichages="1000" epaisseurPoint="2" totalBoucles="5000000" epaisseurLigne="2" arrondiAuto="vrai" nbDecimales="8" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="noteTMP EST_DU_TYPE NOMBRE" code="1#NOMBRE#noteTMP"/>
        <item algoitem="noteMin EST_DU_TYPE NOMBRE" code="1#NOMBRE#noteMin"/>
        <item algoitem="noteMax EST_DU_TYPE NOMBRE" code="1#NOMBRE#noteMax"/>
        <item algoitem="nbNote EST_DU_TYPE NOMBRE" code="1#NOMBRE#nbNote"/>
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="moyenne EST_DU_TYPE NOMBRE" code="1#NOMBRE#moyenne"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Veuillez indiquer le nombre de notes&quot;" code="4#Veuillez indiquer le nombre de notes#0"/>
        <item algoitem="LIRE nbNote" code="2#nbNote#pasliste"/>
        <item algoitem="noteMin PREND_LA_VALEUR 20" code="5#noteMin#20#pasliste"/>
        <item algoitem="noteMax PREND_LA_VALEUR 0" code="5#noteMax#0#pasliste"/>
        <item algoitem="moyenne PREND_LA_VALEUR 0" code="5#moyenne#0#pasliste"/>
        <item algoitem="POUR i ALLANT_DE 1 A nbNote" code="12#i#1#nbNote">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="AFFICHER &quot;Veuillez saisir la note &quot;" code="4#Veuillez saisir la note #0"/>
            <item algoitem="AFFICHER i" code="3#i#0#pasliste"/>
            <item algoitem="LIRE noteTMP" code="2#noteTMP#pasliste"/>
            <item algoitem="SI (noteTMP&lt;noteMin) ALORS" code="6#noteTMP&lt;noteMin">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="noteMin PREND_LA_VALEUR noteTMP" code="5#noteMin#noteTMP#pasliste"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
            </item>
            <item algoitem="SI (noteTMP>noteMax) ALORS" code="6#noteTMP>noteMax">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="noteMax PREND_LA_VALEUR noteTMP" code="5#noteMax#noteTMP#pasliste"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
            </item>
            <item algoitem="moyenne PREND_LA_VALEUR moyenne+noteTMP" code="5#moyenne#moyenne+noteTMP#pasliste"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
        <item algoitem="moyenne PREND_LA_VALEUR moyenne/nbNote" code="5#moyenne#moyenne/nbNote#pasliste"/>
        <item algoitem="AFFICHER &quot;La note max est de &quot;" code="4#La note max est de #0"/>
        <item algoitem="AFFICHER noteMax" code="3#noteMax#0#pasliste"/>
        <item algoitem="AFFICHER &quot;/20&quot;" code="4#/20#1"/>
        <item algoitem="AFFICHER &quot;La note min est &quot;" code="4#La note min est #0"/>
        <item algoitem="AFFICHER noteMin" code="3#noteMin#0#pasliste"/>
        <item algoitem="AFFICHER &quot;/20&quot;" code="4#/20#1"/>
        <item algoitem="AFFICHER &quot;La moyenne des notes est de &quot;" code="4#La moyenne des notes est de #0"/>
        <item algoitem="AFFICHER moyenne" code="3#moyenne#0#pasliste"/>
        <item algoitem="AFFICHER &quot;/20&quot;" code="4#/20#1"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
