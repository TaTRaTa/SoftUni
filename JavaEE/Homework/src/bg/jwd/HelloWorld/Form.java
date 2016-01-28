package bg.jwd.HelloWorld;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Form
 */
@WebServlet("/Form")
public class Form extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Form() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	@Override
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.setContentType("text/html");

		response.getWriter().append("<center><form>"
				+ "Username:<br>"
				+ "<input type=name name=firstname>"
				+ "<br>"
				+ "Pasword:<br>"
				+ "<input type=password name=lastname>"
				+ "<br>"
				+ "Date:<br>"
				+ "<input type=date name=date>"
				+ "</form>"
				+ "<button>cancel</button>  <button>submit</button></center>");
	}

}
