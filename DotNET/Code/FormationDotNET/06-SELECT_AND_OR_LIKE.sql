-- Affichage de la Table EMPLOYEE
SELECT Emp.* FROM EMPLOYEE Emp

-- Requête des recherche des employés dont le nom commence par "S"
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'S%'

-- Requête des recherche des employés dont le nom commence par "S"
-- Et Travail dans le departement ID = 1
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
AND Emp.DEPT_ID = 1

-- Requête des recherche des employés dont le nom commence par "S"
-- Et Travail dans le departement ID = 1
-- Et occupe le poste de caissier (teller)
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
AND Emp.DEPT_ID = 1
AND Emp.TITLE = 'Teller'

-- Requête des recherche des employés dont le nom commence par "S" ou un "J"
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'S%'
OR Emp.FIRST_NAME LIKE 'J%'

-- Requête des recherche des employés dont le nom termine par "an" ou "en"
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE '%an'
OR Emp.FIRST_NAME LIKE '%en'

-- Requête des recherche de l'employés dont le prénom est "Susan" et le nom "Barker"
SELECT Emp.EMP_ID,
		Emp.FIRST_NAME,
		Emp.LAST_NAME,
		Emp.TITLE
FROM EMPLOYEE Emp
WHERE Emp.FIRST_NAME LIKE 'Susan'
AND Emp.LAST_NAME LIKE 'Barker'