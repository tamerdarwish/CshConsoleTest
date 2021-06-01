using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using CshConsoleAPI;



namespace CshConsoleTest
{
	[TestClass]
	public class CommandsTest
	{
		public const string CMD_ECHO_PARAM = "hello echo";
		public const string CMD_LINE_ECHO = "echo(hello world)";
		public const string CMD_ADD_PARAM = "5,3";
		public const string CMD_LINE_ADD = "add(5,3)";
		public const string CMD_SUB_PARAM = "5,3";
		public const string CMD_LINE_SUB = "sub(5,3)";
		public const string CMD_MULT_PARAM = "10,3";
		public const string CMD_LINE_MULT = "mult(10,3)";
		public const string CMD_DIV_PARAM = "10,3";
		public const string CMD_LINE_DIV = "div(10,3)";
		[TestMethod]
		public void TestMethod1()
		{
		}

		[TestMethod]
		public void TestParser()
		{
			//	Check command name parsing.
			Assert.IsTrue(Commands.CMD_ECHO == CommandsApi.CommandName(CMD_LINE_ECHO));

			// Check command parameters parsing.
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_ECHO);
			Assert.IsTrue(1 == parameters.Length);
			return;
		}

		//	Test the echo command function.
		[TestMethod]
		public void TestEcho()
		{
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_ECHO);
			Assert.IsTrue(AppCommands.CommandEcho(parameters));
			return;
		}

		//	Test the commands list using the echo command function.
		[TestMethod]
		public void TestCommandEcho()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding echo command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ECHO, AppCommands.CommandEcho));

			//	Execute the echo command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_ECHO));
			return;
		}


		[TestMethod]
		public void TestAdd()
		{
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_ADD);
			Assert.IsTrue(AppCommands.CommandAdd(parameters));
			return;
		}

		//	Test the commands list using the add command function.
		[TestMethod]
		public void TestCommandAdd()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding add command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ADD, AppCommands.CommandAdd));

			//	Execute the add command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_ADD));
			return;
		}

		[TestMethod]
		public void TestSub()
		{
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_SUB);
			Assert.IsTrue(AppCommands.CommandAdd(parameters));
			return;
		}

		//	Test the commands list using the sub command function.
		[TestMethod]
		public void TestCommandSub()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding sub command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_SUB, AppCommands.CommandSub));

			//	Execute the sub command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_SUB));
			return;
		}

		[TestMethod]
		public void TestMult()
		{
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_MULT);
			Assert.IsTrue(AppCommands.CommandMult(parameters));
			return;
		}

		//	Test the commands list using the mult command function.
		[TestMethod]
		public void TestCommandMult()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding mult command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_MULT, AppCommands.CommandMult));

			//	Execute the mult command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_MULT));
			return;
		}

		[TestMethod]
		public void TestDiv()
		{
			string[] parameters = CommandsApi.CommandParams(CMD_LINE_DIV);
			Assert.IsTrue(AppCommands.CommandMult(parameters));
			return;
		}

		//	Test the commands list using the div command function.
		[TestMethod]
		public void TestCommandDiv()
		{
			//	Check creating a new commands list.
			Commands pCommands = CommandsApi.CommandsInit();
			Assert.IsNotNull(pCommands);

			//	Check adding div command to commands list.
			Assert.IsTrue(CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_DIV, AppCommands.CommandDiv));

			//	Execute the div command in the command list.
			Assert.IsTrue(CommandsApi.CommandExec(ref pCommands, CMD_LINE_DIV));
			return;
		}
	};
}