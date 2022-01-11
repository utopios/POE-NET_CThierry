-- Affichage de la Table EMPLOYEE
SELECT Emp.* FROM EMPLOYEE Emp

-- Requete pour trouver les employé dont l'id est compris entre 5 et 10 inclus
SELECT *
FROM EMPLOYEE Emp
WHERE Emp.EMP_ID BETWEEN 5 AND 10

-- Equivalent
SELECT *
FROM EMPLOYEE Emp
WHERE Emp.EMP_ID >= 5
AND Emp.EMP_ID <=10

-- Requête permettant de retourner les employés dont la date d'embauche est comprise dans un interval de valeurs
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.START_DATE,
		CONVERT(VARCHAR, Emp.START_DATE, 106) AS START_DATE_CONVERT
FROM EMPLOYEE Emp
WHERE Emp.START_DATE
BETWEEN CONVERT(DATETIME, '01 Jan 2002',106)
AND CONVERT(DATETIME,'31 Dec 2002',106)