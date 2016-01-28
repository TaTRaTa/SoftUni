<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%--<%@ taglib prefix="ct" tagdir="/WEB-INF/tags"%>--%>
<%@ taglib prefix="ct" uri="http://jwd.bg/tags" %>

<% boolean isTrue = true; %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Task 7</title>
</head>
<body>
	<center>
		<ct:title title="TASK_7" />
		
		<ct:content/>
				
		<%if(isTrue){ %>
			<ct:currDate/>
		<%} %>
		
		<ct:footer/>
	</center>
</body>
</html>