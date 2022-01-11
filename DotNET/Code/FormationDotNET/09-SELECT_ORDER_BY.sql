-- Affichage de la Table EMPLOYEE
SELECT Emp.* FROM EMPLOYEE Emp

-- Requête permettant de retourner les employés dont la date d'embauche est comprise dans un interval de valeurs ordonnés par ordre croissant
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.START_DATE,
		CONVERT(VARCHAR, Emp.START_DATE, 106) AS START_DATE_CONVERT
FROM EMPLOYEE Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(DATETIME, '01 Jan 2002',106)
AND CONVERT(DATETIME,'31 Dec 2002',106)
ORDER BY START_DATE

-- Requête permettant de retourner les employés dont la date d'embauche est comprise dans un interval de valeurs ordonnés par ordre décroissant
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.START_DATE,
		CONVERT(VARCHAR, Emp.START_DATE, 106) AS START_DATE_CONVERT
FROM EMPLOYEE Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(DATETIME, '01 Jan 2002',106)
AND CONVERT(DATETIME,'31 Dec 2002',106)
ORDER BY START_DATE DESC

-- Affichage de la table PRODUCT
SELECT Pro.PRODUCT_CD,
		Pro.PRODUCT_TYPE_CD,
		Pro.NAME 
FROM PRODUCT Pro

-- Requete pour trier par product_Type en ordre croissant,
-- Puis par nom décroissant
SELECT Pro.PRODUCT_CD,
		Pro.PRODUCT_TYPE_CD,
		Pro.NAME
FROM PRODUCT Pro
ORDER BY Pro.PRODUCT_TYPE_CD ASC,
			Pro.NAME DESC
