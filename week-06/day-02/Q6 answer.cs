//https://lagunita.stanford.edu/courses/DB/SQL/SelfPaced/courseware/ch-sql/seq-exercise-sql_movie_query_core/

SELECT
    reviewer.name, movie.title
FROM
(
    SELECT
        ra2.rID, ra2.mID
    FROM
        rating ra1, rating ra2 
    WHERE
        ra1.mID = ra2.mID
        AND
        ra1.rID = ra2.rID
        AND
        ra1.ratingdate < ra2.ratingdate
        AND
        ra1.stars < ra2.stars
) as t1
INNER JOIN
    movie
ON
    movie.mID = t1.mID
INNER JOIN
    reviewer
ON
    reviewer.rID = t1.rID
;