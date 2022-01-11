-- Affichage de la Table EMPLOYEE
SELECT Emp.* FROM EMPLOYEE Emp

-- Requetes permettant de rechercher des employés avec des criteres multiple sur le même champs
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME IN ('Susan','Paula','Helen')