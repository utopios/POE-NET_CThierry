-- Requ�te pour voir des champs pr�cis de la table OFFICER
SELECT OFFICER_ID, FIRST_NAME, LAST_NAME FROM OFFICER

-- Requ�te pour voir des champs pr�cis de la table EMPLOYEE (Avec Alias)
SELECT Toto.EMP_ID,
		Toto.FIRST_NAME,
		Toto.LAST_NAME,
		Toto.DEPT_ID
FROM EMPLOYEE Toto

-- Requ�te pour voir des champs pr�cis de la table EMPLOYEE (Sans Alias)
SELECT EMP_ID,
		FIRST_NAME,
		LAST_NAME,
		DEPT_ID
FROM EMPLOYEE